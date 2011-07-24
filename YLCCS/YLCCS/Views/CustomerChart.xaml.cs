using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Navigation;
using YLCCS.Web.Services;
using System.Windows.Controls.DataVisualization.Charting;

namespace YLCCS.Views
{
    public partial class CustomerChart : Page
    {
        public CustomerChart()
        {
            InitializeComponent();
            chart1.Title = "健康指数";
        }
        LMDataContext lmdc = new LMDataContext();
        // 当用户导航到此页面时执行。

        string CurUser = WebContext.Current.User.DisplayName;
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
             //CurUser == "admin"?Visibility:"";
            if(CurUser=="admin")
                comboBox1.Visibility = Visibility;
            
            lmdc.Load<Web.Models.BasicData>(lmdc.GetBasicDataQuery()).Completed+=new EventHandler(CustomerChart_Completed2);
            lmdc.Load<Web.Models.Aerobic>(lmdc.GetAerobicQuery()).Completed += new EventHandler(CustomerChart_Completed);

            
            //lmdc.
        }

        void CustomerChart_Completed(object sender, EventArgs e)
        {



            //var list = lmdc.Aerobics.Select(c => new { X = c.Duration, Y = c.ExerciseDate }).GroupBy(c => c.Y).ToList();

            //var list = from p in lmdc.Aerobics
            //           group p by p.ExerciseDate into g
            //           orderby g.Key
            //           select new
            //           {
            //               X = g.Average(p => p.Duration),
            //               Y = g.Key
            //           };

            //var mm = lmdc.Aerobics.GroupBy(c=>c.ExerciseDate).Sum(d => d.Key);
            var srcList = lmdc.Aerobics.Where(c => c.UserId == CurUser);
            var durlist = srcList.GroupBy(a => a.ExerciseDate).Select(a => new { X = a.Average(b => b.Duration), Y = a.Key }).OrderBy(c => c.Y);
            var spdlist = srcList.GroupBy(a => a.ExerciseDate).Select(a => new { X = a.Average(b => b.Speed), Y = a.Key }).OrderBy(c => c.Y);
            var rtlist = srcList.GroupBy(a => a.ExerciseDate).Select(a => new { X = a.Average(b => b.HeartRate), Y = a.Key }).OrderBy(c => c.Y);
            var dtlist = srcList.GroupBy(a => a.ExerciseDate).Select(a => new { X = a.Average(b => b.Distance), Y = a.Key }).OrderBy(c => c.Y);


            LineSeries cs1 = (LineSeries)chart1.Series[0];
            cs1.Title = "锻炼时长";
            cs1.Background = new SolidColorBrush(Colors.Red);
            PointCollection pc = new PointCollection();
            int i = 0;
            foreach (var m in durlist)
            {
                i++;
                pc.Add(new Point(m.X.Value, i));
            }
            cs1.ItemsSource = pc;

            LineSeries cs2 = (LineSeries)chart1.Series[1];
            cs2.Title = "速度";
            cs2.Background = new SolidColorBrush(Colors.Blue);
            PointCollection pc2 = new PointCollection();
            i = 0;
            foreach (var m in spdlist)
            {
                i++;
                pc2.Add(new Point((double)m.X.Value, i));
            }
            cs2.ItemsSource = pc2;

            LineSeries cs3 = (LineSeries)chart1.Series[2];
            cs3.Title = "平均心率";
            cs3.Background = new SolidColorBrush(Colors.Green);
            PointCollection pc3 = new PointCollection();
            i = 0;
            foreach (var m in rtlist)
            {
                i++;
                pc3.Add(new Point(m.X.Value, i));
            }
            cs3.ItemsSource = pc3;

            LineSeries cs4 = (LineSeries)chart1.Series[3];
            cs4.Title = "锻炼距离";
            cs4.Background = new SolidColorBrush(Colors.Yellow);
            PointCollection pc4 = new PointCollection();
            i = 0;
            foreach (var m in dtlist)
            {
                i++;
                pc4.Add(new Point((double)m.X.Value, i));
            }
            cs4.ItemsSource = pc4;



        }


        void CustomerChart_Completed2(object sender, EventArgs e)
        {
            var names = lmdc.BasicDatas.GroupBy(a => a.UserId).Select(a => new { a.Key }).OrderBy(c => c.Key).ToList();
            List<string> uns = new List<string>();
            foreach (var m in names)
            {
                uns.Add(m.Key);
            }

            comboBox1.ItemsSource = uns;
            
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CurUser = comboBox1.SelectedValue.ToString();
            lmdc.Load<Web.Models.Aerobic>(lmdc.GetAerobicQuery()).Completed += new EventHandler(CustomerChart_Completed);
        }
    }
}

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
using YLCCS.Web.Services;
using YLCCS.Web.Models;

namespace YLCCS.Views
{
    public partial class CustomerDataEditor2 : ChildWindow
    {
        public CustomerDataEditor2()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            if (WebContext.Current.User.Roles.SingleOrDefault(c => c == "内部用户") != null)
            {
                tbMC.IsEnabled = true;
            }
            else
            {
                tbMC.Text = WebContext.Current.User.Name;
                tbMC.IsEnabled = false;

            }
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        string LoginUser = WebContext.Current.User.DisplayName;

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            LMDataContext lmdc = new LMDataContext();

            //保存基础数据
            BasicData bd = new BasicData();
            bd.UserId = tbMC.Text;
            bd.ExerciseDate = ddpSJ.SelectedDate.Value;
            bd.Weight = (decimal)nudTJ.Value;
            bd.BloodPressureL = (decimal)nudXYL.Value;
            bd.BloodPressureH = (decimal)nudXYH.Value;
            bd.Recorder = LoginUser;
            lmdc.BasicDatas.Add(bd);

            //保存有氧数据

            //匀速跑步
            if (cbYSPB.IsChecked.Value)
            {
                Aerobic ab = new Aerobic();
                ab.UserId = tbMC.Text;
                ab.ExerciseDate = ddpSJ.SelectedDate.Value;
                ab.Project = "匀速跑步";
                ab.Duration = (int)nudYSPB1.Value;
                ab.HeartRate = (int)nudYSPB2.Value;
                ab.Speed = (decimal)nudYSPB3.Value;
                ab.Distance = (decimal)nudYSPB4.Value;
                ab.Recorder = LoginUser;
                lmdc.Aerobics.Add(ab);
            }
            //有氧操
            if (cbYYC.IsChecked.Value)
            {
                Aerobic ab = new Aerobic();
                ab.UserId = tbMC.Text;
                ab.ExerciseDate = ddpSJ.SelectedDate.Value;
                ab.Project = "有氧操";
                ab.Duration = (int)nudYYC1.Value;
                ab.HeartRate = (int)nudYYC2.Value;
                ab.Speed = (decimal)nudYYC3.Value;
                ab.Distance = (decimal)nudYYC4.Value;
                ab.Recorder = LoginUser;
                lmdc.Aerobics.Add(ab);
            }
            //自行车
            if (cbZXC.IsChecked.Value)
            {
                Aerobic ab = new Aerobic();
                ab.UserId = tbMC.Text;
                ab.ExerciseDate = ddpSJ.SelectedDate.Value;
                ab.Project = "自行车";
                ab.Duration = (int)nudZXC1.Value;
                ab.HeartRate = (int)nudZXC2.Value;
                ab.Speed = (decimal)nudZXC3.Value;
                ab.Distance = (decimal)nudZXC4.Value;
                ab.Recorder = LoginUser;
                lmdc.Aerobics.Add(ab);
            }
            //椭圆机
            if (cbTYJ.IsChecked.Value)
            {
                Aerobic ab = new Aerobic();
                ab.UserId = tbMC.Text;
                ab.ExerciseDate = ddpSJ.SelectedDate.Value;
                ab.Project = "椭圆机";
                ab.Duration = (int)nudTYJ1.Value;
                ab.HeartRate = (int)nudTYJ2.Value;
                ab.Speed = (decimal)nudTYJ3.Value;
                ab.Distance = (decimal)nudTYJ4.Value;
                ab.Recorder = LoginUser;
                lmdc.Aerobics.Add(ab);
            }
            //踏步机
            if (cbTBJ.IsChecked.Value)
            {
                Aerobic ab = new Aerobic();
                ab.UserId = tbMC.Text;
                ab.ExerciseDate = ddpSJ.SelectedDate.Value;
                ab.Project = "踏步机";
                ab.Duration = (int)nudTBJ1.Value;
                ab.HeartRate = (int)nudTBJ2.Value;
                ab.Speed = (decimal)nudTBJ3.Value;
                ab.Distance = (decimal)nudTBJ4.Value;
                ab.Recorder = LoginUser;
                lmdc.Aerobics.Add(ab);
            }
            //游泳
            if (cbYY.IsChecked.Value)
            {
                Aerobic ab = new Aerobic();
                ab.UserId = tbMC.Text;
                ab.ExerciseDate = ddpSJ.SelectedDate.Value;
                ab.Project = "游泳";
                ab.Duration = (int)nudYY1.Value;
                ab.HeartRate = (int)nudYY2.Value;
                ab.Speed = (decimal)nudYY3.Value;
                ab.Distance = (decimal)nudYY4.Value;
                ab.Recorder = LoginUser;
                lmdc.Aerobics.Add(ab);
            }
            /////////////////////////////////////////

            //腹肌
            if (cbFJ.IsChecked.Value)
            {
                Strength st = new Strength();
                st.UserId = tbMC.Text;
                st.ExerciseDate = ddpSJ.SelectedDate.Value;
                st.Project = "腹肌";
                st.Weight = (int)nudFJ1.Value;
                st.Times = (int)nudFJ2.Value;
                st.Groups = (int)nudFJ3.Value;
                st.Recorder = LoginUser;
                lmdc.Strengths.Add(st);
            }
            //腰肌
            if (cbYJ.IsChecked.Value)
            {
                Strength st = new Strength();
                st.UserId = tbMC.Text;
                st.ExerciseDate = ddpSJ.SelectedDate.Value;
                st.Project = "腰肌";
                st.Weight = (int)nudYJ1.Value;
                st.Times = (int)nudYJ2.Value;
                st.Groups = (int)nudYJ3.Value;
                st.Recorder = LoginUser;
                lmdc.Strengths.Add(st);
            }
            //大腿四头肌
            if (cbDTSTJ.IsChecked.Value)
            {
                Strength st = new Strength();
                st.UserId = tbMC.Text;
                st.ExerciseDate = ddpSJ.SelectedDate.Value;
                st.Project = "大腿四头肌";
                st.Weight = (int)nudDTSTJ1.Value;
                st.Times = (int)nudDTSTJ2.Value;
                st.Groups = (int)nudDTSTJ3.Value;
                st.Recorder = LoginUser;
                lmdc.Strengths.Add(st);
            }
            //臀肌
            if (cbTJ.IsChecked.Value)
            {
                Strength st = new Strength();
                st.UserId = tbMC.Text;
                st.ExerciseDate = ddpSJ.SelectedDate.Value;
                st.Project = "臀肌";
                st.Weight = (int)nudTJ1.Value;
                st.Times = (int)nudTJ2.Value;
                st.Groups = (int)nudTJ3.Value;
                st.Recorder = LoginUser;
                lmdc.Strengths.Add(st);
            }
            //胸大肌
            if (cbXDJ.IsChecked.Value)
            {
                Strength st = new Strength();
                st.UserId = tbMC.Text;
                st.ExerciseDate = ddpSJ.SelectedDate.Value;
                st.Project = "胸大肌";
                st.Weight = (int)nudXDJ1.Value;
                st.Times = (int)nudXDJ2.Value;
                st.Groups = (int)nudXDJ3.Value;
                st.Recorder = LoginUser;
                lmdc.Strengths.Add(st);
            }
            //背肌
            if (cbBJ.IsChecked.Value)
            {
                Strength st = new Strength();
                st.UserId = tbMC.Text;
                st.ExerciseDate = ddpSJ.SelectedDate.Value;
                st.Project = "背肌";
                st.Weight = (int)nudBJ1.Value;
                st.Times = (int)nudBJ2.Value;
                st.Groups = (int)nudBJ3.Value;
                st.Recorder = LoginUser;
                lmdc.Strengths.Add(st);
            }
            //仰卧起坐
            if (cbYWQZ.IsChecked.Value)
            {
                Strength st = new Strength();
                st.UserId = tbMC.Text;
                st.ExerciseDate = ddpSJ.SelectedDate.Value;
                st.Project = "仰卧起坐";
                st.Weight = (int)nudYWQZ1.Value;
                st.Times = (int)nudYWQZ2.Value;
                st.Groups = (int)nudYWQZ3.Value;
                st.Recorder = LoginUser;
                lmdc.Strengths.Add(st);
            }
            //大腿内
            if (cbDTN.IsChecked.Value)
            {
                Strength st = new Strength();
                st.UserId = tbMC.Text;
                st.ExerciseDate = ddpSJ.SelectedDate.Value;
                st.Project = "大腿内";
                st.Weight = (int)nudDTN1.Value;
                st.Times = (int)nudDTN2.Value;
                st.Groups = (int)nudDTN3.Value;
                st.Recorder = LoginUser;
                lmdc.Strengths.Add(st);
            }
            //大腿外
            if (cbDTW.IsChecked.Value)
            {
                Strength st = new Strength();
                st.UserId = tbMC.Text;
                st.ExerciseDate = ddpSJ.SelectedDate.Value;
                st.Project = "大腿外";
                st.Weight = (int)nudDTW1.Value;
                st.Times = (int)nudDTW2.Value;
                st.Groups = (int)nudDTW3.Value;
                st.Recorder = LoginUser;
                lmdc.Strengths.Add(st);
            }

            lmdc.SubmitChanges();

            Clean();
        }

        private void Clean()
        {
            cbYSPB.IsChecked = false;

            //有氧操
            cbYYC.IsChecked = false;

            //自行车
            cbZXC.IsChecked = false;

            //椭圆机
            cbTYJ.IsChecked = false;

            //踏步机
            cbTBJ.IsChecked = false;

            //游泳
            cbYY.IsChecked = false;

            /////////////////////////////////////////

            //腹肌
            cbFJ.IsChecked = false;

            //腰肌
            cbYJ.IsChecked = false;

            //大腿四头肌
            cbDTSTJ.IsChecked = false;

            //臀肌
            cbTJ.IsChecked = false;

            //胸大肌
            cbXDJ.IsChecked = false;

            //背肌
            cbBJ.IsChecked = false;

            //仰卧起坐
            cbYWQZ.IsChecked = false;

            //大腿内
            cbDTN.IsChecked = false;

            //大腿外
            cbDTW.IsChecked = false;

        }
    }
}


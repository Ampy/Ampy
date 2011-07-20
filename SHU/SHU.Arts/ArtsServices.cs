using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.Web.Mvc;

namespace SHU.Arts
{
    public class ArtsServices
    {
        static string connstr = "Data Source=|DataDirectory|\\StarterSite.sdf;Persist Security Info=False";
        static string providerstr = "System.Data.SqlServerCe.4.0";
        public static List<Arts> GetArtsBy(string nianji, string xueqi, string kecheng)
        {
            DbProviderFactory dp = DbProviderFactories.GetFactory(providerstr);

            using (DbConnection conn = dp.CreateConnection())
            {
                conn.ConnectionString = connstr;
                conn.Open();
                using (ArtsDataClassDataContext artDC = new ArtsDataClassDataContext(conn))
                {
                    return artDC.Arts.Where(c => c.NianJi == nianji && c.XueQi == xueqi && c.KeCheng == kecheng).ToList();
                }
            }
        }

        public static List<SelectListItem> GetEnumList(string enumtype)
        {
            List<SelectListItem> slList = new List<SelectListItem>();
            DbProviderFactory dp = DbProviderFactories.GetFactory(providerstr);
            using (DbConnection conn = dp.CreateConnection())
            {
                conn.ConnectionString = connstr;
                conn.Open();
                
                using (ArtsDataClassDataContext artDC = new ArtsDataClassDataContext(conn))
                {
                    var list = artDC.EnumList.Where(c => c.EnumType == enumtype);
                    foreach (var m in list)
                    {
                        SelectListItem sl = new SelectListItem();
                        sl.Text = m.Name;
                        sl.Value = m.Name;
                        slList.Add(sl);
                    }
                }
            }
            return slList;
        }

    }
}

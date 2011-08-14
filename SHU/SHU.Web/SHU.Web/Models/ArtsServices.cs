using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.Web.Mvc;

namespace SHU.Web.Models
{
    public class ArtsServices
    {


        public static List<SelectListItem> GetNianJiList()
        {
            List<SelectListItem> slList = new List<SelectListItem>();

            using (ArtDbContext artDC = new ArtDbContext())
            {
                var list = artDC.NianJiBiao.ToList();
                foreach (var m in list)
                {
                    SelectListItem sl = new SelectListItem();
                    sl.Text = m.MingCheng;
                    sl.Value = m.NianJiId;
                    slList.Add(sl);
                }
            }
            return slList;
        }


        public static List<SelectListItem> GetKeChengList()
        {
            List<SelectListItem> slList = new List<SelectListItem>();

            using (ArtDbContext artDC = new ArtDbContext())
            {
                var list = artDC.KeChengBiao.ToList();
                foreach (var m in list)
                {
                    SelectListItem sl = new SelectListItem();
                    sl.Text = m.MingCheng;
                    sl.Value = m.KeChengId;
                    slList.Add(sl);
                }
                return slList;
            }

        }

        public static List<SelectListItem> GetXueQiList()
        {
            List<SelectListItem> slList = new List<SelectListItem>();

            using (ArtDbContext artDC = new ArtDbContext())
            {
                var list = artDC.XueQiBiao.ToList();
                foreach (var m in list)
                {
                    SelectListItem sl = new SelectListItem();
                    sl.Text = m.MingCheng;
                    sl.Value = m.XueQiId;
                    slList.Add(sl);
                }
                return slList;
            }

        }
    }
}

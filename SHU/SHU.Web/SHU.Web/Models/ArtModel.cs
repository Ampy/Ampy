using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SHU.Web.Models
{
    [Table("Arts")]
    public partial class ArtModel
    {
        [Key]
        public System.Guid ID
        {
            get;
            set;
        }


        public string XingMing
        {
            get;
            set;
        }

        public string NianJi
        {
            get;
            set;
        }

        public string Jie
        {
            get;
            set;
        }

        public string XueQi
        {
            get;
            set;
        }

        public string KeCheng
        {
            get;
            set;
        }


        public string JiangXiang
        {
            get;
            set;
        }

        public string ZuoPinLuJing
        {
            get;
            set;
        }

        public string ZuoPinMingCheng
        {
            get;
            set;
        }

        public string Ji
        {
            get;
            set;
        }

    }



}

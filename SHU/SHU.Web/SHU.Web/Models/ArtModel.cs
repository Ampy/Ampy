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
        [Display(Name = "标识")]
        public System.Guid ID
        {
            get;
            set;
        }

        [Display(Name = "姓名")]
        public string XingMing
        {
            get;
            set;
        }

        [Display(Name = "年级")]
        public string NianJiId
        {
            get;
            set;
        }

        [Display(Name = "届")]
        public string Jie
        {
            get;
            set;
        }

        [Display(Name = "学期")]
        public string XueQiId
        {
            get;
            set;
        }

        [Display(Name = "课程")]
        public string KeChengId
        {
            get;
            set;
        }

        [Display(Name = "奖项")]
        public string JiangXiang
        {
            get;
            set;
        }

        [Display(Name = "作品路径")]
        public string ZuoPinLuJing
        {
            get;
            set;
        }

        [Display(Name = "作品缩略图路径")]
        public string ZuoPinLuJing2
        {
            get;
            set;
        }

        [Display(Name = "作品名称")]
        public string ZuoPinMingCheng
        {
            get;
            set;
        }

        [Display(Name = "级")]
        public string Ji
        {
            get;
            set;
        }
        [Display(Name = "课程")]
        public virtual KeChengModel KeCheng { get; set; }
        [Display(Name = "年纪")]
        public virtual NianJiModel NianJi { get; set; }
        [Display(Name = "学期")]
        public virtual XueQiModel XueQi { get; set; }
    }



}

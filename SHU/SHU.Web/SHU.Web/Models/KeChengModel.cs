using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SHU.Web.Models
{
    [Table("KeChengBiao")]
    public class KeChengModel
    {
        [Key]
        public string KeChengId { get; set; }

        public string MingCheng { get; set; }

        public int? PaiXu { get; set; }
    }
}
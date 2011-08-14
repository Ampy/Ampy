using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SHU.Web.Models
{
    [Table("NianJi")]
    public class NianJiModel
    {
        [Key]
        public string NianJiId { get; set; }
        public string MingCheng { get; set; }

    }


}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SHU.Web.Models
{
    [Table("XueQi")]
    public class XueQiModel
    {
        [Key]
        public string XueQiId { get; set; }
        public string MingCheng { get; set; }

    }


}
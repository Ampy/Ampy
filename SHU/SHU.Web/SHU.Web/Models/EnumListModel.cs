using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SHU.Web.Models
{
    [Table("EnumList")]
    public partial class EnumListModel
    {

        [Key]
        public int ID
        {
            get;
            set;
        }

        public string EnumType
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public int Sort
        {
            get;
            set;
        }

    }
}
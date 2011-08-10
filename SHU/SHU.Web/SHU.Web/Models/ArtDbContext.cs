using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Common;

namespace SHU.Web.Models
{
    public class ArtDbContext:DbContext
    {
        public ArtDbContext(DbConnection existingConnection, bool contextOwnsConnection):base(existingConnection, contextOwnsConnection)
        {
            
        }

        public DbSet<ArtModel> Arts { get; set; }
        public DbSet<EnumListModel> EnumLists { get; set; }
    }
}
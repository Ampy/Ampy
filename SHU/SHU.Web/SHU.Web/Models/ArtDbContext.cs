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
        static string connstr = "Data Source=|DataDirectory|\\StarterSite.sdf;Persist Security Info=False";
        static string providerstr = "System.Data.SqlServerCe.4.0";

        static DbConnection Connection {
            get
            {
                DbProviderFactory dp = DbProviderFactories.GetFactory(providerstr);
                DbConnection conn = dp.CreateConnection();
                conn.ConnectionString = connstr;
                return conn;
            }
        }

        public ArtDbContext()
            : base(Connection,true)
        {

            
        }

        public ArtDbContext(DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {

        }

        public DbSet<ArtModel> Arts { get; set; }
        public DbSet<EnumListModel> EnumLists { get; set; }
        public DbSet<NianJiModel> NianJiBiao { get; set; }
        public DbSet<KeChengModel> KeChengBiao { get; set; }
        public DbSet<XueQiModel> XueQiBiao { get; set; }
    }
}
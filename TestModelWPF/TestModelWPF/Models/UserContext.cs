using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TestModelWPF.Models
{
    internal class UserContext : DbContext
    {

        public DbSet<User> Users { get; set; }

        public UserContext()
        {
           Database.EnsureCreated();
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                // SQL Server connection with port
                //optionsBuilder.UseSqlServer("Server=localhost,63027;Database=UserDatabase;Trusted_Connection=True;");

                // SQL Server connection with localdb
                //optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=UserDatabase;Trusted_Connection=True;");

                // SQL Server connection from App.config
                //optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["ConnectionLocalDb"].ToString());

                // SQlite
                //optionsBuilder.UseSqlite(ConfigurationManager.ConnectionStrings["ConnectionSQLite"].ToString());
                //optionsBuilder.UseSqlite(@"DataSource=ColledgeStore.db;");

            }
        }


    }
}

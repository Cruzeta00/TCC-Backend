using APIBackEnd.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace APIBackEnd.Database
{
    public class ModeloDBContext : DbContext
    {
        public DbSet<ModeloLogin> ModeloLogins { get; set; }

        public string DbPath { get; }

        public ModeloDBContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "TCC.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Data Source=CRUZETOBOOK\\SQLEXPRESS;Initial Catalog=TCC;Integrated Security=true");
    }
}
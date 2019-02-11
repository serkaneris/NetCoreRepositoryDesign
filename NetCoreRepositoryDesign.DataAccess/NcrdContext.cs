using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NetCoreRepositoryDesign.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreRepositoryDesign.DataAccess
{
    public class NcrdContext:DbContext
    {
        public NcrdContext(DbContextOptions<NcrdContext> options) : base(options)
        {

        }

        //Bu kisim migrations icin eklendi.
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //Todo: Connection string static alinabilir!
        //    //string connectionStr = "Server=DESKTOP-U3CMHH9\\SQLEXPRESS;Database=NcrdDb;Trusted_Connection=True;";
        //    string connectionStr = "Server=SERKANERIS\\SQLEXPRESS;Database=NcrdDb;Trusted_Connection=True;";
        //    optionsBuilder.UseSqlServer(connectionStr);
        //}



        public DbSet<Department> Departments { get; set; }
        public DbSet<Personnel> Personnels { get; set; }
    }
}

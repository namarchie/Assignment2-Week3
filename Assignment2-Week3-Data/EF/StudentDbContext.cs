using Assignment2_Week3_Data.Configurations;
using Assignment2_Week3_Data.Entities;
using Assignment2_Week3_Data.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2_Week3_Data.EF
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new ProvinceConfiguration());
            modelBuilder.ApplyConfiguration(new DistrictConfiguration());
            modelBuilder.ApplyConfiguration(new CommuneConfiguration());
            modelBuilder.Seed();
            //base.OnModelCreating(modelBuilder);
        }
        
        public DbSet<Student> Students { set; get; }
        public DbSet<Province> Provinces { set; get; }
        public DbSet<District> Districts { set; get; }
        public DbSet<Commune> Communes { set; get; }
    }
}

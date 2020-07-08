using Assignment2_Week3_Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2_Week3_Data.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired(true);
            builder.Property(x => x.Yob).IsRequired(true);
            builder.Property(x => x.Phone);
            builder.Property(x => x.Address).IsRequired();
            //builder.Property(x => x.AddressFull).IsRequired();
        }
    }
}

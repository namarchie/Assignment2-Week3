using Assignment2_Week3_Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2_Week3_Data.Configurations
{
    class DistrictConfiguration : IEntityTypeConfiguration<District>
    {
        public void Configure(EntityTypeBuilder<District> builder)
        {
            builder.ToTable("Districts");
            builder.HasKey(x => x.DistrictId);
            builder.Property(x => x.DistrictName).IsRequired(true);
            builder.Property(x => x.ProvinceId).IsRequired(true);
            builder.HasOne(x => x.Province).WithMany(x => x.Districts).HasForeignKey(x => x.ProvinceId);

        }
    }
}

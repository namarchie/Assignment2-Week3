using Assignment2_Week3_Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2_Week3_Data.Configurations
{
    class CommuneConfiguration : IEntityTypeConfiguration<Commune>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Commune> builder)
        {
            builder.ToTable("Communes");
            builder.HasKey(x => x.CommuneId);
            builder.Property(x => x.CommuneName);
            builder.HasOne(x => x.District).WithMany(x => x.Communes).HasForeignKey(x => x.DistrictId);
        }
    }
}

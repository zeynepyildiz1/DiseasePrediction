using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using DiseasePredictionProject.Core.Models;

namespace DiseasePredictionProject.Data.Configurations
{
    class DiseaseConfiguration : IEntityTypeConfiguration<Disease>
    {
        public void Configure(EntityTypeBuilder<Disease> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.DiseaseName).IsRequired().HasMaxLength(200);
            builder.ToTable("Diseases");
        }
    }
}
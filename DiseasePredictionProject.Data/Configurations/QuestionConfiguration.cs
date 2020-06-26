using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using DiseasePredictionProject.Core.Models;

namespace DiseasePredictionProject.Data.Configurations
{
    class QuetionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.QuestionText).IsRequired().HasMaxLength(500);
            builder.ToTable("Questions");
        }
    }
}

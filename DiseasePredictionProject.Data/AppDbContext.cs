﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using DiseasePredictionProject.Core.Models;
using DiseasePredictionProject.Data.Configurations;
using DiseasePredictionProject.Data.Seeds;

namespace DiseasePredictionProject.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base
         (options)
        {
              
        }
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<Question> Questions { get; set; }

        //   public DbSet<Category> Categories { get; set; }
        // public DbSet<Product> Products { get; set; }
        // public DbSet<Person> Persons { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            //  modelBuilder.Entity<Product>().Property(x => x.Id);
            //  modelBuilder.ApplyConfiguration(new ProductConfiguration());
            //modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new DiseaseConfiguration());
            modelBuilder.ApplyConfiguration(new QuetionConfiguration());
            //modelBuilder.ApplyConfiguration(new ProductSeed(new int[] { 1,2}));
            //modelBuilder.ApplyConfiguration(new CategorySeed(new int[] { 1, 2 }));
            modelBuilder.ApplyConfiguration(new DiseaseSeed());
            modelBuilder.ApplyConfiguration(new QuestionSeed());
            // modelBuilder.Entity<Person>().HasKey(x => x.Id);
            //modelBuilder.Entity<Person>().Property(x => x.Id).UseIdentityColumn();
            //modelBuilder.Entity<Person>().Property(x => x.Name).HasMaxLength(100);
            //modelBuilder.Entity<Person>().Property(x => x.Surname).HasMaxLength(100);
        }
    }
}

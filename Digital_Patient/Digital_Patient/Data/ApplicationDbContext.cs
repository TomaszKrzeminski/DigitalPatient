using System;
using System.Collections.Generic;
using System.Text;
using Digital_Patient.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Digital_Patient.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



            modelBuilder.Entity<TaskToDo>()
           .HasOne<IntervalData>(s => s.IntervalData)
           .WithOne(ad => ad.TaskToDo)
           .HasForeignKey<IntervalData>(ad => ad.TaskToDoId);

            modelBuilder.Entity<Measurement>()
         .HasOne<Note>(s => s.Note)
         .WithOne(ad => ad.Measurement)
         .HasForeignKey<Note>(ad => ad.MeasurementId);


        }


        public new DbSet<ApplicationUser> Users { get; set; }
        public DbSet<TaskToDo> TasksToDo { get; set; }
        public DbSet<TaskToDoCategory> TaskCategories { get; set; }
        public DbSet<IntervalData> IntervalData { get; set; }
        public DbSet<Measurement> Measurements { get; set; }
        public DbSet<MeasurementCategory> MeasurementCategories { get; set; }
        public DbSet<MeasurementPair> MeasurementPairs { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<IntervalCorrectTimeAction> IntervalCorrectTimeActions { get; set; }
        public DbSet<IntervalCorrectTime> CorrectTimes { get; set; }





    }
}

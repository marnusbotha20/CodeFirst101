﻿using Microsoft.EntityFrameworkCore;
using SchoolContext.Models;
using System;

namespace SchoolDBContext
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options) { }

        public SchoolDbContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Declare composite keys for Bridging Tables
            modelBuilder.Entity<StudentCourse>().HasKey(sc => new { sc.StudentId, sc.CourseId });
            modelBuilder.Entity<CourseSubject>().HasKey(cs => new { cs.CourseId, cs.SubjectId });

            modelBuilder.Entity<Entity>().HasMany(e => e.StudentList);

            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.Student)
                .WithMany(b => b.CourseList)
                .HasForeignKey(bc => bc.StudentId);

            modelBuilder.Entity<StudentCourse>()
                .HasOne(bc => bc.Course)
                .WithMany(c => c.StudentList)
                .HasForeignKey(bc => bc.CourseId);

            modelBuilder.Entity<CourseSubject>()
                .HasOne(sc => sc.Course)
                .WithMany(b => b.SubjectList)
                .HasForeignKey(bc => bc.CourseId);

            modelBuilder.Entity<CourseSubject>()
                .HasOne(bc => bc.Subjects)
                .WithMany(c => c.CourseList)
                .HasForeignKey(bc => bc.SubjectId);


        }

        public DbSet<Entity> Entity { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Subjects> Subjects { get; set; }
        public DbSet<CourseSubject> CourseSubjects { get; set; }
        public DbSet<StudentCourse> StudentCourse { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MARNUS-LT;Database=SchoolDB;Trusted_Connection=True;");
        }
    }
}

using Migrations.Models;
using SchoolDBContext;
using System.Collections.Generic;
using System.Data.Entity.Migrations;

namespace SchoolDBContext.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<SchoolDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SchoolDbContext context)
        {
            var students = new List<Student>
            {
                new Student { Name = "Carson",   Surname = "Alexander" },
                new Student { Name = "Meredith", Surname = "Alonso"},
                new Student { Name = "Arturo",   Surname = "Anand"},
                new Student { Name = "Gytis",    Surname = "Barzdukas"},
                new Student { Name = "Yan",      Surname = "Li"},
                new Student { Name = "Peggy",    Surname = "Justice"},
                new Student { Name = "Laura",    Surname = "Norman"},
                new Student { Name = "Nino",     Surname = "Olivetto"}
            };

            //students.ForEach(s => context.Studen.AddOrUpdate(p => p.LastName, s));
            //context.SaveChanges();

            var courses = new List<Course>
            {
                new Course {CourseName = "Chemistry",      Credits = 3},
                new Course {CourseName = "Microeconomics", Credits = 3},
                new Course {CourseName = "Macroeconomics", Credits = 3},
                new Course {CourseName = "Calculus",       Credits = 4},
                new Course {CourseName = "Trigonometry",   Credits = 4},
                new Course {CourseName = "Composition",    Credits = 3},
                new Course {CourseName = "Literature",     Credits = 4}
            };
            //courses.ForEach(s => context.Courses.AddOrUpdate(p => p.Title, s));
            //context.SaveChanges();
        }
    }
}

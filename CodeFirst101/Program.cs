using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Migrations.Models;
using SchoolDBContext;

namespace CodeFirst101
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select Action to perform...");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Display Students");
            Console.WriteLine("3. Add Default Data");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    AddStudents();
                    GetStudents();
                    break;
                case 2:
                    GetStudents();
                    break;
                default:
                    AddDefaultData();
                    break;
            }

            Console.ReadLine();
        }

        private static void GetStudents()
        {
            //using var context = new SchoolDbContext();
            //var students = context.Students.Where(s => s.Name == "Marnus").Include(i => i.Course).ToList();

            //foreach (var item in students)
            //{
            //    Console.WriteLine($"Student No.: {item.Id.ToString()}, Student Name: {item.Name}, Student Surname: {item.Surname}, Course:{item.Course.CourseName}");
            //}

            //Student studentWithCourse = context.Students.FromSql("Select * from Students where Name ='Marnus'")
            //                                            .Include(s => s.Course).FirstOrDefault();
        }

        static void AddStudents()
        {
            using var context = new SchoolDbContext();

            Console.WriteLine("Student Name:");
            string Name = Console.ReadLine();
            Console.WriteLine("Student Surname:");
            string Surname = Console.ReadLine();

            var std = new Student()
            {
                Name = Name,
                Surname = Surname
            };

            context.Students.Add(std);
            context.SaveChanges();
        }

        public static string GetName()
        {
            return "Marnus";
        }

        public static void AddDefaultData()
        {
            using var context = new SchoolDbContext();

            var course = new Course()
            {
                CourseName = "Code First 101"
            };

            var courseList = new List<StudentCourse>()
            { 
                new StudentCourse()
                { 
                    StudentId = 1,
                    CourseId  = 1
                }
            };

            var data = new Student()
            {
                Name = "Marnus",
                Surname = "Botha",
                CourseList = courseList
            };

            //var subjects = new Subjects()
            //{
            //    SubjectName = "Maths 101",
            //    Marks = 90
            //};

            //var course = new Course()
            //{
            //    CourseName = "CodeFirst 101"
            //};

            //var courseDetails = new CourseDetails()
            //{
            //    CourseId = course.Id,
            //    SubjectsId = subjects.Id
            //};

            //var std = new Student()
            //{
            //    Name = "Marnus",
            //    Surname = "Botha",
            //    Course = course
            //};

            context.Students.Add(data);
            context.SaveChanges();
        }
    }
}

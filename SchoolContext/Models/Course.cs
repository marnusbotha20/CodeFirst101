using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Migrations.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string CourseName { get; set; }
        public int Credits { get; set; }
        public ICollection<StudentCourse> StudentList { get; set; }
        public ICollection<CourseSubject> SubjectList { get; set; }
    }
}

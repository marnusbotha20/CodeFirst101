using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchoolContext.Models
{
    public class Subjects
    {
        [Key]
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public decimal Marks { get; set; }
        public ICollection<CourseSubject> CourseList { get; set; }
    }
}

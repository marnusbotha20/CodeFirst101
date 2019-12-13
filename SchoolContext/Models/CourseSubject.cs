using System;
using System.Collections.Generic;
using System.Text;

namespace Migrations.Models
{
    public class CourseSubject
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int SubjectId { get; set; }
        public Subjects Subjects { get; set; }
    }
}

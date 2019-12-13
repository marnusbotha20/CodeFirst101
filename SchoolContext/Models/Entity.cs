using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolContext.Models
{
    public class Entity
    {
        public int Id { get; set; }
        public string EntityName { get; set; }
        public ICollection<Student> StudentList { get; set; }
    }
}

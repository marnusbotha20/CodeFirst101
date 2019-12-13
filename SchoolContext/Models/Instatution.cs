using System;
using System.Collections.Generic;
using System.Text;

namespace Migrations.Models
{
    public class Instatution
    {
        public int Id { get; set; }
        public string EntityName { get; set; }
        public ICollection<Student> StudentList { get; set; }
    }
}

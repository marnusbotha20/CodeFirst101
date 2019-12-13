using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Text;

namespace SchoolContext
{
    internal sealed class Configuration : DbMigrationsConfiguration<Enity.DAL.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
    }
}

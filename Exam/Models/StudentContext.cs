using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Exam.Models
{
    public class StudentContext: DbContext
    {
        public StudentContext()
        {
            this.Configuration.ProxyCreationEnabled = false;
        }
        public DbSet<Student> Students { get; set; }
    }
}
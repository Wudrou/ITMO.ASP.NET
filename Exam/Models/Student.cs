using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace Exam.Models
{
    public class Student
    {
        public virtual int StudentId { get; set; }

        [DisplayName ("Имя")]
        public virtual string FirstName { get; set; }

        [DisplayName ("Фамилия")]
        public virtual string LastName { get; set; }

        [DisplayName ("Номер группы")]
        public virtual string Group { get; set; }

        [DisplayName ("Литература")]
        public virtual int Value_Literature { get; set; }

        [DisplayName ("Математика")]
        public virtual int Value_Maths { get; set; }

        [DisplayName ("Физика")]
        public virtual int Value_Physics { get; set; }

        [DisplayName ("Химия")]
        public virtual int Value_Chemistry { get; set; }

        [DisplayName ("История")]
        public virtual int Value_History { get; set; }

        [DisplayName("Общий балл")]
        public virtual int Total { get { return Value_Literature + Value_Maths + Value_Physics + Value_Chemistry + Value_History; } }
    }
}
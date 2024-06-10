using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kkjnkhk_
{
    internal class Classes
    {
    }

    public class Student 
    {
    public int Id { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string middle_name { get; set; } 
    public DateTime Birth_day { get; set; }
    public string address { get; set; }
    public string program { get; set; } 
    }

    public class Course {
    public string Course_code { get;set; }
    public string Course_desc { get; set; }
    public int Units { get; set; }
    }
    public class Enrollment 
    {
        public int Enrollment_id { get; set; }
        public int Student_id { get;set;}
        public string Course_code { get; set; }
        public DateTime Enrollment_date { get; set; }   
    }
    public class ITCuriculum
    {
        public int id { get; set; }
        public string course_code { get; set; }
        public int year_offered { get; set; }
        public string sem_offered { get; set; }
    }

    public class Subject {
        public string Course_code { get; set; }
        public string Course_desc { get; set; }
        public int Units { get; set; }
        public int year_offered { get; set; }
        public string sem_offered { get; set; }

    }
}

public class Charges
{
    public int Id { get; set; }
    public decimal Rate_per_units { get; set; }
    public decimal Miscellaneous_fee { get; set; }
    public string School_year { get; set; }
    public string Semester { get; set; }

    public override string ToString()
    {
        return $" {School_year} / {Semester}";
    }
}



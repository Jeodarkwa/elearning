using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElearningPlatform.Core
{
    public class Personel
    {
        public Int16 ID { get; set; }
        public String Name { get; set; }
        public String SirName { get; set; }
        public DateTime BirthDate { get; set; }
        public String Address { get; set; }
        public Int16 PhoneNumber{ get; set; }
        public String PlaceOfBirth { get; set; }
        public string Church { get; set; }

        public virtual void Validate()
        {

        }
    }


    public class Student : Personel
    {
        public String Pastors { get; set; }
        public IExams Exams { get; set; }
    }


    public class Teacher : Personel
    {

    }


   

}
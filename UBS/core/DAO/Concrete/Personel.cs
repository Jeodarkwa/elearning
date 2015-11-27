using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElearningPlatform.Core.DAO
{

    public class Personel : IPersonel
    {
        public Int16 ID { get; set; }
        public String Name { get; set; }
        public String SirName { get; set; }
        public String Country { get; set; }
        public DateTime BirthDate { get; set; }
        public String Address { get; set; }
        public String Occupation { get; set; }
        public int PhoneNumber{ get; set; }
        public int MobilNumber { get; set; }
        public String PlaceOfBirth { get; set; }
        public string Denomination { get; set; }
        public String Pastor { get; set; }
        public String Email { get; set; }
        public string MartialStutus { get; set; } 


        public virtual void Validate()
        {

        }
    }

    public class Student : Personel
    {

        public IExams Exams { get; set; }
    }


    public class Teacher : Personel
    {

    }
}


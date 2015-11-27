using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElearningPlatform.Core
{
   public interface IPersonel
    {
         Int16 ID { get; set; }
         String Name { get; set; }
         String SirName { get; set; }
         String Country { get; set; }
         DateTime BirthDate { get; set; }
         String Address { get; set; }
         String Occupation { get; set; }
         int PhoneNumber { get; set; }
         int MobilNumber { get; set; }
         String PlaceOfBirth { get; set; }
         string Denomination { get; set; }
         String Pastor { get; set; }
         String Email { get; set; }
         string MartialStutus { get; set; } 

    }


  public interface IStudent : IPersonel
   {

       IExams Exams { get; set; }
   }


  public interface ITeacher : IPersonel
   {

   }

}

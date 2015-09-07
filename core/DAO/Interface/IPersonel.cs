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
         DateTime BirthDate { get; set; }
         String Address { get; set; }
         Int16 PhoneNumber { get; set; }
         String PlaceOfBirth { get; set; }
         string Church { get; set; }
    }


   interface Student : IPersonel
   {
       String Pastors { get; set; }
       IExams Exams { get; set; }
   }


   interface Teacher : IPersonel
   {

   }

}

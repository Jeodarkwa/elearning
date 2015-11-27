using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElearningPlatform.Core
{
   public interface IExams
    {
        int ExamsID { get; set; }
        //public String Exams_ID { get; set; }
        IQuestion Exmas_Question { get; set; }
        Array Answers { get; set; }

    }
}

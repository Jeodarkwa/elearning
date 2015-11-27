using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElearningPlatform.Core.DAO
{
    public class Exams : IExams
    {

            public int ExamsID { get; set; }
            //public String Exams_ID { get; set; }
            public IEnquires Exmas_Question { get; set; }
            public Array Answers { get; set; }

    }
}
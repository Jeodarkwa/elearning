using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CORE.DAO
{
    public class Exams
    {
        public Int16 Exams_ID { get; set; }
        //public String Exams_ID { get; set; }
        public Questions Exmas_Question { get; set; }
        public Array Answers { get; set; }
        
    }
}
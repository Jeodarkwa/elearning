using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ElearningPlatform.Core
{
    public class BLLFactory : IBLLFactroy
    {
       

        public IExamsBLL BuildExamsBLL()
        {
            return new ExamsBLL();
        }
    }
}
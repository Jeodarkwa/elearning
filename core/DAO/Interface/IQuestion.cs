using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElearningPlatform.Core
{
    public interface IQuestion
    {
        
        Question Questions{ get; set; }

         int QuestionID { get; set; }
         String ExamsQuestion { get; set; }
         String multiplechoice1 { get; set; }
         String multiplechoice2 { get; set; }
         String multiplechoice3 { get; set; }
         Char selectedAnswer { get; set; }

    }
}

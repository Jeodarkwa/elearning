using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElearningPlatform.Core
{
    public class Question : IQuestion
    {
        private Question _question;
        public Question Questions
        {
            get { return _question; }
            set
            {
                _question = value;
                QuestionID = _question.QuestionID;
                ExamsQuestion = _question.ExamsQuestion;
                multiplechoice1 = _question.multiplechoice1;
                multiplechoice2 = _question.multiplechoice2;
                multiplechoice3 = _question.multiplechoice3;
            }
        }

  
        public int QuestionID { get; set; }
        public String ExamsQuestion { get; set; }
        public String multiplechoice1 { get; set; }
        public String multiplechoice2 { get; set; }
        public String multiplechoice3 { get; set; }
        public Char selectedAnswer { get; set; }

    }    
}
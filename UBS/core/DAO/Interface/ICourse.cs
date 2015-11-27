using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElearningPlatform.Core.DAO;

namespace ElearningPlatform.Core
{
    public interface ICourse
    {
          int Id { get; set; }
         String Name { get; set; }
        public string Notes { get; set; }
        private List<ISubject> subjects; 
        public int CourseNumberOfSubject { get; set; }


         ICourse(List<ISubject> subjects)
        {
            this.subjects = subjects;
        }

        public ICourse(int numberOfSubjects)
        {
            CourseNumberOfSubject = this.subjects.Count();
        }

        public void AddSubject(ISubject subject)
        {
            subjects.Add(subject);
        }

    }

    public interface ISubject
    {
        int Id { get; set; }
        String Name { get; set; }
        string Notes { get; set; }
        IList<IExams> IQuiz { get; set; }
        public int NumberOfQuiz { get; set; }

        public ISubject(int numberOfQuiz)
        {
            NumberOfQuiz = this.IQuiz.Count();
        }
    }

    public interface IExams
    {
         int Id { get; set; }
         String Name { get; set; }
         string Notes { get; set; }
         IList<IQuestion> IQuestion { get; set; }
         int NumberOfQuestion { get; set; }
         Quiz(int numberOfQuestion)
        {
            NumberOfQuestion = this.IQuestion.Count();
        }
    }


    public interface IQuestion
    {
         int Id { get; set; }
         String Name { get; set; }
         string Notes { get; set; }
         int Answer { get; set; }

         IList<ISolution> ISolution { get; set; }
         int NumberOfSolution { get; set; }

        public IQuestion(int numberOfSolution)
        {
            NumberOfSolution = this.ISolution.Count();
        }
    }

    public interface ISolution
    {
         int Id { get; set; }
         String Name { get; set; }
         string Notes { get; set; }
         int NumberOfQuestion { get; set; }
    }








    public interface IEnquires
    {
        Enquires Questions{ get; set; }

         int QuestionID { get; set; }
         String ExamsQuestion { get; set; }
         String multiplechoice1 { get; set; }
         String multiplechoice2 { get; set; }
         String multiplechoice3 { get; set; }
         String multiplechoice4 { get; set; }
         String multiplechoice5 { get; set; }
         Char selectedAnswer { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElearningPlatform.Core.DAO
{

    public class Course : ICourse
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public string Notes { get; set; }
        private List<ISubject> subjects; 
        public int CourseNumberOfSubject { get; set; }

        

        //public List<ISubject> Subjects
        //{
        //    get { return subjects; }
        //    set { subjects = value; }
        //}
        

        public Course(List<ISubject> subjects)
        {
            this.subjects = subjects;
        }

        public void AddSubject(ISubject subject)
        {
            subjects.Add(subject);
           // CourseNumberOfSubject = this.subjects.Count();
        }

        public Course(int CourseNumberOfSubject)
        {
            CourseNumberOfSubject = this.subjects.Count();
        }

    }

    public class Subject : ISubject
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public string Notes { get; set; }
        public List<IExams> Quizs { get; set; }
        public int SubjectNumberOfQuiz { get; set; }

        public Subject(List<IExams> Quizs)
        {
            this.Quizs = Quizs;
        }

        public Subject(int numberOfSubjects)
        {
            SubjectNumberOfQuiz = this.Quizs.Count();
        }

        public void AddQuiz(IExams Quiz)
        {
            Quizs.Add(Quiz);
        }
    }

    public class Exams
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public string Notes { get; set; }
        public IList<Question> Question { get; set; }
        public int NumberOfQuestion { get; set; }
        public Exams(int numberOfQuestion)
        {
            NumberOfQuestion = this.Question.Count();
        }
    }


    public class Question
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public string Notes { get; set; }
        public int Answer {get; set;}

        public IList<Solution> Solution { get; set; }
        public int NumberOfSolution { get; set; }
        
        public Question(int numberOfSolution)
        {
            NumberOfSolution = this.Solution.Count();
        }
    }

    public class Solution
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public string Notes { get; set; }
        
    }






    public class Enquires : IEnquires
    {
        private Enquires _question;
        public Enquires Questions
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
                multiplechoice4 = _question.multiplechoice4;
                multiplechoice5 = _question.multiplechoice5;
            }
        }


        public int QuestionID { get; set; }
        public String ExamsQuestion { get; set; }
        public String multiplechoice1 { get; set; }
        public String multiplechoice2 { get; set; }
        public String multiplechoice3 { get; set; }
        public String multiplechoice4 { get; set; }
        public String multiplechoice5 { get; set; }
        public Char selectedAnswer { get; set; }

    }
}
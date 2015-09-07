using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;



namespace ElearningPlatform.Core
{
    public class ExamsBLL : IExamsBLL
    {
        public int correctQuestion(Exams StudentAnswer)
        {
            char questionAnswer = getAnswerByquestionId(StudentAnswer.Exmas_Question.QuestionID);
            int result = 0;
            if (questionAnswer == StudentAnswer.Exmas_Question.selectedAnswer)
                result = 1;

            return result;
        }


        public IList<IExams> GetExamsByIDs(int ExamsID)
        {
            IList<IExams> newExams = new List<IExams>();

            IExamsDAL getExamsQuestions = ServiceLocator.GetCurrentDALFactory().BuildExamsDal(); 
           
            DataSet newSetOfExams = getExamsQuestions.getExamsByID(ExamsID);
            foreach (DataTable table in newSetOfExams.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    IExams requestedExams = new Exams();
                    Question requestedQuestions = new Question();
                    requestedQuestions.QuestionID = int.Parse(row["Questions_ID"].ToString());
                    requestedQuestions.ExamsQuestion = row["Questions_Main"].ToString();
                    requestedQuestions.multiplechoice1 = row["MultipleChoice1"].ToString();
                    requestedQuestions.multiplechoice2 = row["MultipleChoice2"].ToString();
                    requestedQuestions.multiplechoice3 = row["MultipleChoice3"].ToString();
                    if (String.IsNullOrEmpty(row["Question_Answer"].ToString()))
                        requestedQuestions.selectedAnswer = Char.Parse(row["Question_Answer"].ToString());
                    requestedExams.Exams_ID = int.Parse(row["Exams_ID"].ToString());
                    requestedExams.Exmas_Question = requestedQuestions;
                    newExams.Add(requestedExams);
                }
            }
            return newExams;
        }


        //public void convertDataSetIntoList()
        //{
        //}

        private IDictionary<int, char> getAnswersByExamsId(int ExamsID)
        {
            IDictionary<int, char> dictExamsAnswers = new Dictionary<int, char>();
            IExamsDAL examsAnswers = ServiceLocator.GetCurrentDALFactory().BuildExamsDal(); 
            DataSet dtSetAnswers;
            dtSetAnswers = examsAnswers.getExamsByID(ExamsID);
            if (dtSetAnswers != null)
            {
                foreach (DataTable table in dtSetAnswers.Tables)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        int answerID = int.Parse(row["Questions_ID"].ToString());
                        char answer = Char.Parse(row["Question_Answer"].ToString());
                        dictExamsAnswers.Add(answerID, answer);
                    }
                }
            }
            return dictExamsAnswers;
        }


        private char getAnswerByquestionId(int questionID)
        {
            char answer = new char();
            IExamsDAL examsAnswers = ServiceLocator.GetCurrentDALFactory().BuildExamsDal(); 
            DataSet dtSetAnswers;
            dtSetAnswers = examsAnswers.getAnswerByQuestionID(questionID);

            if (dtSetAnswers != null)
            {
                foreach (DataTable table in dtSetAnswers.Tables)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        answer = Char.Parse(row["Question_Answer"].ToString());
                    }
                }
            }
            return answer;
        }

        private IDictionary<int, char> getAnswersById(int ExamsID, int questionID)
        {
            IDictionary<int, char> dictExamsAnswers = new Dictionary<int, char>();
        //    IExamsDAL examsAnswers = BLLFactory.BuildExamsDal();
            IExamsDAL examsAnswers = ServiceLocator.GetCurrentDALFactory().BuildExamsDal(); 
           
            DataSet dtSetAnswers;
            dtSetAnswers = examsAnswers.getAnswerByID(ExamsID, questionID);

            if (dtSetAnswers != null)
            {
                foreach (DataTable table in dtSetAnswers.Tables)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        int answerID = int.Parse(row["Questions_ID"].ToString());
                        char answer = Char.Parse(row["Question_Answer"].ToString());
                        dictExamsAnswers.Add(answerID, answer);
                    }
                }
            }
            return dictExamsAnswers;
        }


        public int correctExam(IList<IExams> studentAnswers, int examsId)
        {
            //todo insert student answers and results in DB
            int results = 0;
            IDictionary<int, char> examsAnswers = getAnswersByExamsId(examsId);

            foreach (IExams studentAnswer in studentAnswers)
            {
                foreach (KeyValuePair<int, char> answer in examsAnswers)
                {
                    int score = 0;
                    
                    if (studentAnswer.Exmas_Question.QuestionID == answer.Key)
                    {
                        if (studentAnswer.Exmas_Question.selectedAnswer == answer.Value)
                        {
                            score = 1;
                        }
                        results += score;
                    }
                }
            }
            return results;
        }
    }
}

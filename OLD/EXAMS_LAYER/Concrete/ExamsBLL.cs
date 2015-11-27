using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CORE.DAO;
using CORE.DAL;
using System.Data;


namespace BUSINESS_LAYER.EXAMSCORE
{
    public class ExamsDAL
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="StudentAnswer"></param>
        /// <param name="ExamsID"></param>
        /// <returns></returns>
        public int correctQuestion(Exams StudentAnswer)
        {
            char questionAnswer = getAnswerByquestionId(StudentAnswer.Exmas_Question.Question_ID);
            int result = 0;
            if (questionAnswer == StudentAnswer.Exmas_Question.selectedAnswer)
                result = 1;

            return result;
        }


        public List<Exams> GetExamsByID(int ExamsID)
        {
            List<Exams> newExams = new List<Exams>();

            Exams getExamsQuestions = new Exams();
            DataSet newSetOfExams = getExamsQuestions.getExamsByID(ExamsID);
            foreach (DataTable table in newSetOfExams.Tables)
            {
                foreach (DataRow row in table.Rows)
                {

                    Exams requestedExams = new Exams();
                    Questions requestedQuestions = new Questions();
                    requestedQuestions.Question_ID = int.Parse(row["Questions_ID"].ToString());
                    requestedQuestions.Question = row["Questions_Main"].ToString();
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


        public void convertDataSetIntoList()
        {

        }



        
        private static Dictionary<int, char> getAnswersByExamsId(int ExamsID)
        {
            Dictionary<int, char> dictExamsAnswers = new Dictionary<int, char>();
            Exams examsAnswers = new Exams();
            DataSet dtSetAnswers;
            dtSetAnswers = examsAnswers.getAnswersByExamsID(ExamsID);

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


        private static  char getAnswerByquestionId(int questionID)
        {
            char answer = new char(); 
            Exams examsAnswers = new Exams();
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




        /// <summary>
        /// 
        /// </summary>
        /// <param name="ExamsID"></param>
        /// <returns></returns>
        private static Dictionary<int, char> getAnswersById(int ExamsID, int questionID)
        {
           Dictionary<int, char> dictExamsAnswers = new Dictionary<int, char>();
           Exams examsAnswers = new Exams();
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="studentAnswers"></param>
        /// <param name="ExamsID"></param>
        /// <returns></returns>
        public int correctExam(List<Exams> studentAnswers, int examsId)
        {
            //todo insert student answers and results in DB

            int results = 0;
            Dictionary<int, char> examsAnswers = getAnswersByExamsId(examsId);

            foreach (Exams studentAnswer in studentAnswers)
            {
                foreach (KeyValuePair<int, char> answer in examsAnswers)
                {
                    int score = 0;
                    if (studentAnswer.Exmas_Question.Question_ID == answer.Key)
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
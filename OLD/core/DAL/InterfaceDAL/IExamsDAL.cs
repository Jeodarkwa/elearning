using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElearningPlatform.Core
{
   public interface IExamsDAL
    {
       /// <summary>
       /// 
       /// </summary>
       /// <param name="examsID"></param>
       /// <param name="questionID"></param>
       /// <returns></returns>
        DataSet getAnswerByID(int examsID, int? questionID);
       /// <summary>
       /// 
       /// </summary>
       /// <param name="questionID"></param>
       /// <returns></returns>
        DataSet getAnswerByQuestionID(int questionID);
       /// <summary>
       /// 
       /// </summary>
       /// <param name="examsID"></param>
       /// <returns></returns>
        DataSet getAnswersByExamsID(int examsID);
       /// <summary>
       /// 
       /// </summary>
       /// <param name="examsID"></param>
       /// <returns></returns>
        DataSet getExamsByID(int examsID);
       /// <summary>
       /// 
       /// </summary>
       /// <param name="studentID"></param>
       /// <param name="ExamsID"></param>
        void InsertStudentAnswer(int studentID, int ExamsID);
       /// <summary>
       /// 
       /// </summary>
       /// <param name="studentID"></param>
       /// <param name="examsID"></param>
       /// <param name="score"></param>
       /// <param name="studentsAnswers"></param>
       /// <param name="comments"></param>
        void InsertStudentScore(int studentID, int examsID, int score, string[] studentsAnswers, string comments);
       /// <summary>
       /// 
       /// </summary>
       /// <param name="studentID"></param>
       /// <param name="examsID"></param>
       /// <param name="score"></param>
       /// <param name="studentsAnswers"></param>
        void InsertStudentScore(int studentID, int examsID, int score, string[] studentsAnswers);
    }
}

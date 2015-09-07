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
        DataSet getAnswerByID(int examsID, int? questionID);
        DataSet getAnswerByQuestionID(int questionID);
        DataSet getAnswersByExamsID(int examsID);
        DataSet getExamsByID(int examsID);
        void InsertStudentAnswer(int studentID, int ExamsID);
        void InsertStudentScore(int studentID, int examsID, int score);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElearningPlatform.Core
{
    public interface IExamsBLL
    {
        int correctQuestion(Exams StudentAnswer);
        IList<IExams> GetExamsByIDs(int ExamsID);
        int correctExam(IList<IExams> studentAnswers, int examsId); 

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ElearningPlatform.Core;
using System.Data;

namespace ElearningPlatform.Core
{
    public interface IExamsBLL
    {
        int correctQuestion(IExams StudentAnswer);
        IList<IExams> GetExamsByIDs(int ExamsID);
        int correctExam(IList<IExams> studentAnswers, int examsId);
        DataSet ExamQuestionsNSolutionGet(int examsID);

    }
}

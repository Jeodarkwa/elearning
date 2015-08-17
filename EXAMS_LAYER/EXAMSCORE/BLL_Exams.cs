using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BUSINESS_LAYER.EXAMSCORE
{
    public class BLL_Exams
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="StudentAnswers"></param>
        /// <param name="ExamsID"></param>
        /// <returns></returns>
        public int[] correctExam(string[] StudentAnswers, int ExamsID)
        {
            string[] questionAnswer = getAnswers(ExamsID);
            
            int[] results = new int[StudentAnswers.Count()];

            for (int i = 0; i <= StudentAnswers.Count(); i++)
            {
                if (StudentAnswers[i] == questionAnswer[i])
                    results[i] = 1; 
            }

            return results; 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ExamsID"></param>
        /// <returns></returns>
        private static string[] getAnswers(int ExamsID)
        {
            string[] answers = { "a", "b", "c" };

            //TO do get exams results
            return answers;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selectedAnswers"></param>
        /// <param name="ExamsID"></param>
        /// <returns></returns>
        public List<int[]> correctExamS(List<string[]> selectedAnswers, int ExamsID)
        {
            List<int[]> results = new List<int[]>();
            
            foreach(string[] selectedAnswer in selectedAnswers)
            {
                int[] rest = new int[2];
                rest = correctExam(selectedAnswer, ExamsID);
                results.Add(rest);
            }

            return results; 
        }
    }
}
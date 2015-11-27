using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ElearningPlatform.Core.DAL 
{
    public class ExamsDAL : IExamsDAL
    {

        /// <summary>
        /// Get Answer by exams ID and question ID
        /// </summary>
        /// <param name="examsID"></param>
        /// <param name="questionID"></param>
        /// <returns></returns>
        public DataSet getAnswerByID(int examsID, int? questionID)
        {
            if(examsID <= 0 || questionID <= 0)
            throw new ArgumentNullException("Null Values");


            DataSet questionList = new DataSet("examsAnswes");
            try
            {
                using (SqlConnection stringConnection = new SqlConnection(ConnString.localConnection()))
                {
                    using (SqlCommand sqlCom = new SqlCommand())
                    {
                        sqlCom.Connection = stringConnection;
                        Int32 rowsAffected;
                        sqlCom.CommandType = CommandType.StoredProcedure;
                        sqlCom.CommandText = "stPcd_QuestionAnswerGetByID";

                        //sqlCom.Parameters.Add("@examsID", SqlDbType.Int, examsID);
                        sqlCom.Parameters.AddWithValue("@ExamsId", examsID);
                        sqlCom.Parameters.AddWithValue("@QuestionId", questionID);

                        stringConnection.Open();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCom);
                        // dataAdapter.SelectCommand = sqlCom;

                        dataAdapter.Fill(questionList);
                        rowsAffected = sqlCom.ExecuteNonQuery();
                        stringConnection.Close();
                    }
                }
            }
            catch (Exception ee)
            {
                //Obravnava napak
                Console.Write(ee);
            }
            finally
            {

            }
            return questionList;
        }


        /// <summary>
        /// Get question Answer by Question ID
        /// </summary>
        /// <param name="questionID"></param>
        /// <returns></returns>
        public DataSet getAnswerByQuestionID(int questionID)
        {
            DataSet questionList = new DataSet("examsAnswes");
            try
            {
                using (SqlConnection stringConnection = new SqlConnection(ConnString.localConnection()))
                {
                    using (SqlCommand sqlCom = new SqlCommand())
                    {
                        sqlCom.Connection = stringConnection;
                        Int32 rowsAffected;
                        sqlCom.CommandType = CommandType.StoredProcedure;
                        sqlCom.CommandText = "stPcd_QuestionAnswerGetByID";

                        sqlCom.Parameters.AddWithValue("@QuestionId", questionID);
                        stringConnection.Open();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCom);
                        // dataAdapter.SelectCommand = sqlCom;

                        dataAdapter.Fill(questionList);
                        rowsAffected = sqlCom.ExecuteNonQuery();
                        stringConnection.Close();
                    }
                }
            }
            catch (Exception ee)
            {
                Console.Write(ee);
            }
            finally
            {

            }
            return questionList;
        }


        /// <summary>
        /// Get Answers of the Exams by Exams ID
        /// </summary>
        /// <param name="examsID"></param>
        /// <returns>DataSet</returns>
        public DataSet getAnswersByExamsID(int examsID)
        {
            if (examsID <= 0)
                throw new ArgumentNullException("Null Values"); 

            DataSet questionList = new DataSet("examsAnswes");
            try
            {
                using (SqlConnection stringConnection = new SqlConnection(ConnString.localConnection()))
                {
                    using (SqlCommand sqlCom = new SqlCommand())
                    {
                        sqlCom.Connection = stringConnection;
                        Int32 rowsAffected;
                        sqlCom.CommandType = CommandType.StoredProcedure;
                        sqlCom.CommandText = "stPcd_QuestionAnswerGetByID";

                        sqlCom.Parameters.AddWithValue("@ExamsId", examsID);

                        stringConnection.Open();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCom);

                        dataAdapter.Fill(questionList);
                        rowsAffected = sqlCom.ExecuteNonQuery();
                        stringConnection.Close();
                    }
                }
            }
            catch (Exception ee)
            {
                //Obravnava napak
                Console.Write(ee);
            }
            finally
            {

            }
            return questionList;
        }


        /// <summary>
        /// Get Questions by Exams ID
        /// </summary>
        /// <param name="examsID"></param>
        /// <returns></returns>
        public DataSet getExamsByID(int examsID)
        {

            DataSet questionList = new DataSet("examsData"); 
            try
            {
            
                using (SqlConnection stringConnection = new SqlConnection(ConnString.localConnection()))
                {

                    
                    using (SqlCommand sqlCom = new SqlCommand())
                    {
                        sqlCom.Connection = stringConnection;
                        Int32 rowsAffected;
                        sqlCom.CommandType = CommandType.StoredProcedure;
                        sqlCom.CommandText = "stPcd_ExamsGetByID";

                        //sqlCom.Parameters.Add("@examsID", SqlDbType.Int, examsID);
                        sqlCom.Parameters.AddWithValue("@ExamsId", examsID);

                        stringConnection.Open();
                        SqlDataAdapter dataAdapter =new SqlDataAdapter(sqlCom);
                       // dataAdapter.SelectCommand = sqlCom;
                       
                        dataAdapter.Fill(questionList);
                        rowsAffected = sqlCom.ExecuteNonQuery();
                        stringConnection.Close(); 
                       
                    }
                }
            }
            catch (Exception ee)
            {
                //Obravnava napak
                Console.Write(ee);
            }
            finally
                {
                    
                }
            return questionList;
        }


        /// <summary>
        /// Get Questions by Exams ID
        /// </summary>
        /// <param name="examsID"></param>
        /// <returns></returns>
        public DataSet ExamQuestionsNSolutionGet(int examsID)
        {

            DataSet questionList = new DataSet("examsData");
            try
            {

                using (SqlConnection stringConnection = new SqlConnection(ConnString.localConnection()))
                {


                    using (SqlCommand sqlCom = new SqlCommand())
                    {
                        sqlCom.Connection = stringConnection;
                        Int32 rowsAffected;
                        sqlCom.CommandType = CommandType.StoredProcedure;
                        sqlCom.CommandText = "stPcd_ExamQuestionNSolutionGet";

                        //sqlCom.Parameters.Add("@examsID", SqlDbType.Int, examsID);
                        sqlCom.Parameters.AddWithValue("@ExamsId", examsID);

                        stringConnection.Open();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCom);
                        // dataAdapter.SelectCommand = sqlCom;

                        dataAdapter.Fill(questionList);
                        rowsAffected = sqlCom.ExecuteNonQuery();
                        stringConnection.Close();

                    }
                }
            }
            catch (Exception ee)
            {
                //Obravnava napak
                Console.Write(ee);
            }
            finally
            {

            }
            return questionList;
        }


        public void InsertStudentAnswer(int studentID, int ExamsID)
        {
            throw new NotImplementedException(); 
        }


        /// <summary>
        /// Insert Student Score with comments
        /// </summary>
        /// <param name="studentID"></param>
        /// <param name="examsID"></param>
        /// <param name="score"></param>
        /// <param name="studentsAnswers"></param>
        /// <param name="comments"></param>
        public void InsertStudentScore(int studentID, int examsID, int score, string[] studentsAnswers, string comments)
        {

            try
            {

                using (SqlConnection stringConnection = new SqlConnection())
                {
                    using (SqlCommand sqlCom = new SqlCommand())
                    {
                        sqlCom.Connection = stringConnection;
                       
                        sqlCom.CommandType = CommandType.StoredProcedure;
                        sqlCom.CommandText = "stPcd_ScoreNAnswersInsert";

                        //sqlCom.Parameters.Add("@examsID", SqlDbType.Int, examsID);
                        sqlCom.Parameters.AddWithValue("@UserId", studentID);
                        sqlCom.Parameters.AddWithValue("@ExamsId", examsID);
                        sqlCom.Parameters.AddWithValue("@ExamsScore", score);
                        sqlCom.Parameters.AddWithValue("@Answer", studentsAnswers);
                        sqlCom.Parameters.AddWithValue("@Comments", comments);

                        stringConnection.Open();
                        stringConnection.Close();
                    }
                }
            }
            catch (Exception ee)
            {
                //Obravnava napak
                Console.Write(ee);
            }
            finally
            {

            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="studentID"></param>
        /// <param name="examsID"></param>
        /// <param name="score"></param>
        /// <param name="studentsAnswers"></param>
        public void InsertStudentScore(int studentID, int examsID, int score, string[] studentsAnswers)
        {

            try
            {

                using (SqlConnection stringConnection = new SqlConnection(ConnString.localConnection()))
                {
                    using (SqlCommand sqlCom = new SqlCommand())
                    {
                        sqlCom.Connection = stringConnection;

                        sqlCom.CommandType = CommandType.StoredProcedure;
                        sqlCom.CommandText = "stPcd_ScoreNAnswersInsert";
                        sqlCom.Parameters.AddWithValue("@UserId", studentID);
                        sqlCom.Parameters.AddWithValue("@ExamsId", examsID);
                        sqlCom.Parameters.AddWithValue("@ExamsScore", score);
                        sqlCom.Parameters.AddWithValue("@Answers", studentsAnswers);
                      

                        stringConnection.Open();
                        stringConnection.Close();
                    }
                }
            }
            catch (Exception ee)
            {
                //Obravnava napak
                Console.Write(ee);
            }
            finally
            {

            }
        }
    }
}
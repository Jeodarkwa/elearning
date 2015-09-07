using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ElearningPlatform.Core 
{
    public class ExamsDAL : IExamsDAL
    {

        public String localConnection()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString();
        }



        public DataSet getAnswerByID(int examsID, int? questionID)
        {

            DataSet questionList = new DataSet("examsAnswes");
            try
            {

                using (SqlConnection stringConnection = new SqlConnection(localConnection()))
                {
                    using (SqlCommand sqlCom = new SqlCommand())
                    {
                        sqlCom.Connection = stringConnection;
                        Int32 rowsAffected;
                        sqlCom.CommandType = CommandType.StoredProcedure;
                        sqlCom.CommandText = "stPcd_getQuestionAnswerByID";

                        //sqlCom.Parameters.Add("@examsID", SqlDbType.Int, examsID);
                        sqlCom.Parameters.AddWithValue("@examsID", examsID);
                        sqlCom.Parameters.AddWithValue("@questionID", questionID);

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



        public DataSet getAnswerByQuestionID(int questionID)
        {
            DataSet questionList = new DataSet("examsAnswes");
            try
            {
                using (SqlConnection stringConnection = new SqlConnection(localConnection()))
                {
                    using (SqlCommand sqlCom = new SqlCommand())
                    {
                        sqlCom.Connection = stringConnection;
                        Int32 rowsAffected;
                        sqlCom.CommandType = CommandType.StoredProcedure;
                        sqlCom.CommandText = "stPcd_getQuestionAnswerByID";

                        sqlCom.Parameters.AddWithValue("@questionID", questionID);
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



        public DataSet getAnswersByExamsID(int examsID)
        {

            DataSet questionList = new DataSet("examsAnswes");
            try
            {
                using (SqlConnection stringConnection = new SqlConnection(localConnection()))
                {
                    using (SqlCommand sqlCom = new SqlCommand())
                    {
                        sqlCom.Connection = stringConnection;
                        Int32 rowsAffected;
                        sqlCom.CommandType = CommandType.StoredProcedure;
                        sqlCom.CommandText = "stPcd_getQuestionAnswerByID";

                        sqlCom.Parameters.AddWithValue("@examsID", examsID);

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


        public DataSet getExamsByID(int examsID)
        {

            DataSet questionList = new DataSet("examsData"); 
            try
            {
            
                using (SqlConnection stringConnection = new SqlConnection(localConnection()))
                {

                    
                    using (SqlCommand sqlCom = new SqlCommand())
                    {
                        sqlCom.Connection = stringConnection;
                        Int32 rowsAffected;
                        sqlCom.CommandType = CommandType.StoredProcedure;
                        sqlCom.CommandText = "stPcd_getExamsByID";

                        //sqlCom.Parameters.Add("@examsID", SqlDbType.Int, examsID);
                        sqlCom.Parameters.AddWithValue("@examsID", examsID);

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



        public void InsertStudentAnswer(int studentID, int ExamsID)
        {
            throw new NotImplementedException(); 
        }

        public void InsertStudentScore(int studentID, int examsID, int score)
        {

            try
            {

                using (SqlConnection stringConnection = new SqlConnection())
                {
                    using (SqlCommand sqlCom = new SqlCommand())
                    {
                        sqlCom.Connection = stringConnection;
                       
                        sqlCom.CommandType = CommandType.StoredProcedure;
                        sqlCom.CommandText = "stPcd_getExamsByID";

                        //sqlCom.Parameters.Add("@examsID", SqlDbType.Int, examsID);
                        sqlCom.Parameters.AddWithValue("@studentID", studentID);
                        sqlCom.Parameters.AddWithValue("@@ExamsID", examsID);
                        sqlCom.Parameters.AddWithValue("@score", score);

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
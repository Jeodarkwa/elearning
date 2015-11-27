using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ElearningPlatform.Core.DAL
{
    public class AccountDAL : IAccountDAL
    {

        //public void CreateUserAccount(string Login, string email, String password)
        //{

        //    if (String.IsNullOrEmpty(Login)
        //        && String.IsNullOrEmpty(password)
        //        && String.IsNullOrEmpty(email))
        //    {
        //        try
        //        {

        //            using (SqlConnection stringConnection = new SqlConnection(ConnString.ConnString.localConnection()))
        //            {
        //                using (SqlCommand sqlCom = new SqlCommand())
        //                {
        //                    sqlCom.Connection = stringConnection;

        //                    sqlCom.CommandType = CommandType.StoredProcedure;
        //                    sqlCom.CommandText = "[stPcd_LoginAccountCreate]";

        //                    sqlCom.Parameters.AddWithValue("@LoginName", Login);
        //                    sqlCom.Parameters.AddWithValue("@email", email);
        //                    sqlCom.Parameters.AddWithValue("@password", password);

        //                    var returnParameter = sqlCom.Parameters.Add("@return_value", SqlDbType.Int);
        //                    returnParameter.Direction = ParameterDirection.ReturnValue;

        //                    stringConnection.Open();
        //                    sqlCom.ExecuteNonQuery();
        //                    var result = returnParameter.Value;
        //                }
        //            }
        //        }
        //        catch (Exception ee)
        //        {
        //            Console.Write(ee);
        //        }
        //        finally
        //        {

        //        }
        //    }
        //}

        public Boolean CanAccessSite(String UserName, String Password)
        {
            if (String.IsNullOrEmpty(UserName) || String.IsNullOrEmpty(Password))
                throw new ArgumentNullException("Null Values");

            bool CanAccess = false;
            String DBresult = null;
            try
            {
                using (SqlConnection stringConnection = new SqlConnection(ConnString.localConnection()))
                {
                    using (SqlCommand sqlCom = new SqlCommand())
                    {
                        sqlCom.Connection = stringConnection;

                        sqlCom.CommandType = CommandType.StoredProcedure;
                        sqlCom.CommandText = "[stPcd_LoginAuthentication]";

                        sqlCom.Parameters.AddWithValue("@login", UserName);
                        sqlCom.Parameters.AddWithValue("@password", Password);

                        var returnParameter = sqlCom.Parameters.Add("@return_value", SqlDbType.Int);
                        returnParameter.Direction = ParameterDirection.ReturnValue;

                        stringConnection.Open();
                        sqlCom.ExecuteNonQuery();
                        DBresult = returnParameter.Value.ToString();

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

            if(!String.IsNullOrEmpty(DBresult))
            if (int.Parse(DBresult) > 0)
                CanAccess = true;

            return CanAccess;
        }

        public int GetUerIdByLogin(String UserName, String Password)
        {
            if (String.IsNullOrEmpty(UserName) || String.IsNullOrEmpty(Password))
                throw new ArgumentNullException("Null Values");


            String DBresult = null;
            try
            {

                using (SqlConnection stringConnection = new SqlConnection(ConnString.localConnection()))
                {
                    using (SqlCommand sqlCom = new SqlCommand())
                    {
                        sqlCom.Connection = stringConnection;

                        sqlCom.CommandType = CommandType.StoredProcedure;
                        sqlCom.CommandText = "[stPcd_LoginAuthentication]";

                        sqlCom.Parameters.AddWithValue("@login", UserName);
                        sqlCom.Parameters.AddWithValue("@password", Password);

                        var returnParameter = sqlCom.Parameters.Add("@return_value", SqlDbType.Int);
                        returnParameter.Direction = ParameterDirection.ReturnValue;

                        stringConnection.Open();
                        sqlCom.ExecuteNonQuery();
                        DBresult = returnParameter.Value.ToString();
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

            int UserId = int.Parse(DBresult);

            return UserId;
        }

        public DataSet GetUserByLogin(String UserName, String Password)
        {
            if (String.IsNullOrEmpty(UserName) || String.IsNullOrEmpty(Password))
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
                        sqlCom.CommandText = "[stPcd_UsersGet]";

                        sqlCom.Parameters.AddWithValue("@login", UserName);
                        sqlCom.Parameters.AddWithValue("@password", Password);

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

        public int CreateUserAccount(string Login, String password,  int userId)
        {

            if (String.IsNullOrEmpty(Login)
                || String.IsNullOrEmpty(password)
                || userId <= 0)
            {
                throw new ArgumentNullException("Null Values");
            }
           
                string Dbresult = null; 
                try
                {
                   
                    using (SqlConnection stringConnection = new SqlConnection(ConnString.localConnection()))
                    {
                        using (SqlCommand sqlCom = new SqlCommand())
                        {
                            sqlCom.Connection = stringConnection;

                            sqlCom.CommandType = CommandType.StoredProcedure;
                            sqlCom.CommandText = "[stPcd_LoginAccountCreate]";

                            sqlCom.Parameters.AddWithValue("@LoginName", Login);
                            sqlCom.Parameters.AddWithValue("@userId", userId);
                            sqlCom.Parameters.AddWithValue("@password", password);

                            var returnParameter = sqlCom.Parameters.Add("@return_value", SqlDbType.Int);
                            returnParameter.Direction = ParameterDirection.ReturnValue;

                            stringConnection.Open();
                            sqlCom.ExecuteNonQuery();
                            Dbresult = returnParameter.Value.ToString();
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
            int results = 0; 
            if(!String.IsNullOrEmpty(Dbresult))
                results = int.Parse(Dbresult);

            return results; 
        }

        public void ChangePassword()
        {
            //todo  new NotImplementedException(); 

        }
    }
}
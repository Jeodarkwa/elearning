using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

using ElearningPlatform.Core; 
using ElearningPlatform.Core.DAO; 

namespace ElearningPlatform.Core.DAL
{
    public class StudentDAL
    {


        public void CreateStudent(IStudent student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Students date is null"); 
            }
            else
            {
                try
                {

                    using (SqlConnection stringConnection = new SqlConnection(ConnString.localConnection()))
                    {
                        using (SqlCommand sqlCom = new SqlCommand())
                        {
                            sqlCom.Connection = stringConnection;

                            sqlCom.CommandType = CommandType.StoredProcedure;
                            sqlCom.CommandText = "stPcd_StudentCreate";

                            sqlCom.Parameters.AddWithValue("@studentName", student.ID);
                            sqlCom.Parameters.AddWithValue("@studentSirName", student.SirName);
                            sqlCom.Parameters.AddWithValue("@studentCountry", student.Country);
                            sqlCom.Parameters.AddWithValue("@studentAddress", student.Address);
                            sqlCom.Parameters.AddWithValue("@studentTelephone", student.PhoneNumber);
                            sqlCom.Parameters.AddWithValue("@studentMobil", student.MobilNumber);
                            sqlCom.Parameters.AddWithValue("@studentBirthDate", student.BirthDate);
                            sqlCom.Parameters.AddWithValue("@studentOccupation", student.Occupation);
                            sqlCom.Parameters.AddWithValue("@studentDenomination", student.Denomination);
                            sqlCom.Parameters.AddWithValue("@studentClass", student.MartialStutus);

                            stringConnection.Open();
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
            }
        }



        public void StudentsGetAll()
        {

        }


        public void StudentsGetByID(int studentID)
        {

        }

        public void UpdateStudent()
        {

        }

        public void DeleteStudent()
        {

        }




    }
}
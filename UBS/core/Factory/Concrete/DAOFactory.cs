using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using ElearningPlatform.Core.DAO;

namespace ElearningPlatform.Core
{
    public static class DAOFactory 
    {
       

        public static IExams BuildExamsDAO()
        {
            return new Exams();
        }

        public static IPersonel BuildPersonelDAO()
        {
            return new Personel();
        }

        public static IEnquires BuildQuestionDAO()
        {
            return new Enquires(); 
        }


        public static IAccount BuildAccountDAO()
        {
            return new Account();
        }

    }
}
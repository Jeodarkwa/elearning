using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ElearningPlatform.Core.DAL;

namespace ElearningPlatform.Core
{
    public class DALFactory : IDALFactory
    {

        public IExamsDAL BuildExamsDal()
        {
           
            return new ExamsDAL();
        }

        public IAccountDAL BuildAccountDAL()
        {
            return new AccountDAL(); 
        }
       
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElearningPlatform.Core
{
    public class DALFactory : IDALFactory
    {

        public IExamsDAL BuildExamsDal()
        {
           
            return new ExamsDAL();
        }

       
    }
}
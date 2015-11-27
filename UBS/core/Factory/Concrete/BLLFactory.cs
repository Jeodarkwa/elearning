using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using ElearningPlatform.Core.DAO;

namespace ElearningPlatform.Core
{
    public class BLLFactory : IBLLFactroy
    {
       

        public IExamsBLL BuildExamsBLL()
        {
            return new ExamsBLL();
        }

        public IAccountBLL BuildAccountBLL()
        {
            return new AccountBLL(); 
        }
    }
}
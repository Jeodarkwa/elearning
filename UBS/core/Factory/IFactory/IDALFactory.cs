using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElearningPlatform.Core
{
   public interface IDALFactory
    {
       IExamsDAL BuildExamsDal();
       IAccountDAL BuildAccountDAL(); 
    }
}

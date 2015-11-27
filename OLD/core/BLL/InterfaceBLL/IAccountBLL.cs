using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ElearningPlatform.Core.DAO;

namespace ElearningPlatform.Core
{
   public interface IAccountBLL
    {
       string CreateLoginAccount(String UserName, int userId, String Password, String ConfirmPassword);
       bool LoginUser(IAccount account); 
    }
}

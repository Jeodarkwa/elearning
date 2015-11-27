using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElearningPlatform.Core
{
  public  interface IAccountDAL
    {
      
     void CreateUserAccount(string Login, string email, String password);
      Boolean CanAccessSite(String UserName, String Password); 
      int GetUerIdByLogin(String UserName, String Password); 
      DataSet GetUserByLogin(String UserName, String Password);
      int CreateUserLogin(string Login, String password, int userId);

    }
}

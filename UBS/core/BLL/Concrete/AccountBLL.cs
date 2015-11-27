using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ElearningPlatform.Core.DAO; 

namespace ElearningPlatform.Core
{
    public class AccountBLL: IAccountBLL
    {

        public bool LoginUser(IAccount account)
        {
            bool loginUser = false;
           account.Password = CommonFiles.EncryptToString(account.Password); 

            IAccountDAL loginDal = ServiceLocator.GetCurrentDALFactory().BuildAccountDAL();
    
            loginUser = loginDal.CanAccessSite(account.Login,account.Password); 

            return loginUser; 
        }
 
        public string CreateLoginAccount(String UserName, int userId, String Password, String ConfirmPassword)
        {

            if (!Password.Equals(ConfirmPassword) && String.IsNullOrEmpty(UserName)
                && String.IsNullOrEmpty(Password) && String.IsNullOrEmpty(ConfirmPassword)
                && userId <= 0)
                throw new ArgumentNullException("Null Values"); 

            
                String encryptedPassword = CommonFiles.EncryptToString(Password);
                int UserAccountCreated = 0;
                string CreatedSucessfully = "Recreate Account Again"; 
                IAccountDAL CreaterAccount = ServiceLocator.GetCurrentDALFactory().BuildAccountDAL();
                UserAccountCreated = CreaterAccount.CreateUserLogin(UserName, encryptedPassword, userId);

                if (UserAccountCreated > 0)
                {
                    CreatedSucessfully = "Account Successfully created";
                }
                else if (UserAccountCreated == -2)
                {
                    CreatedSucessfully = "Account Already Exist";
                }
                else
                {
                    CreatedSucessfully = "Please Try Again";
                }
                
            return CreatedSucessfully; 
        }
    }
}
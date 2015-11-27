using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;


using ElearningPlatform.Core.DAO;
using ElearningPlatform.Core; 

public partial class Account_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

           protected void btnLogin_Click(object sender, EventArgs e)
        {
            IAccount userAccount = DAOFactory.BuildAccountDAO();
            userAccount.Login = txtUserName.Text;
            userAccount.Password = txtPassword.Text;

            if (userAccount == null)
            {
                ErrorMessage.Text = "UserName and Password cannot be empty";
            }
            else
            {
                IAccountBLL accountAuthtentication = ServiceLocator.GetCurrentBLLFactory().BuildAccountBLL();
           //     accountAuthtentication.CreateLoginAccount("john", 2, "pass", "pass"); 

                if (accountAuthtentication.LoginUser(userAccount))
                {
                    FormsAuthentication.RedirectFromLoginPage(userAccount.Login, true);
                }
                else
                {
                    ErrorMessage.Text = "Password or UserName is wrong";
                }
             
            }

        }
    }
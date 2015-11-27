using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ElearningPlatform.Core.DAO;
using ElearningPlatform.Core;


namespace elearning_platform.Acc
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void confermRegistration_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            String password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            int userId = 2;  //todo getUserId

            if (password.Equals(confirmPassword) || String.IsNullOrEmpty(userName)
            || String.IsNullOrEmpty(password) || String.IsNullOrEmpty(confirmPassword)
            || userId <= 0)

                ErrorMessage.Text = "Fields cannot be empty"; 

            IAccountBLL registerUser = ServiceLocator.GetCurrentBLLFactory().BuildAccountBLL();

            ErrorMessage.Text = registerUser.CreateLoginAccount(userName, userId, password, confirmPassword); 
        }


    }
}
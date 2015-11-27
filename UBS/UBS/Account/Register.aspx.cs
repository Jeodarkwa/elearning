using ElearningPlatform.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using ElearningPlatform.Core.DAO;


public partial class Account_Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void confermRegistration_Click(object sender, EventArgs e)
    {
        string Name = txtName.Text;
        string SirName = txtSirName.Text;
        string Email = txtEmail.Text;
        string Country = txtCountry.Text;
        string Address = txtAddress.Text;
        string Telephone = txtTelephone.Text;
        string Mobile = txtMobile.Text;
        
        string DateOfBirth = txtBirthDate.Text;
        string Occupation = txtOcuupation.Text;
        string Denomination = txtDenomination.Text;
        
        String password = txtPassword.Text;
        string confirmPassword = txtConfirmPassword.Text;
        int RoleId = int.Parse(ddlRole.SelectedValue.ToString());
        int MarrigeStatusId = int.Parse(ddlMarriageStatus.SelectedValue.ToString());

        if (password.Equals(confirmPassword) || String.IsNullOrEmpty(Name)
        || String.IsNullOrEmpty(password) || String.IsNullOrEmpty(confirmPassword)
        || RoleId <= 0)

            ErrorMessage.Text = "Fields cannot be empty";

        IAccountBLL registerUser = ServiceLocator.GetCurrentBLLFactory().BuildAccountBLL();

        ErrorMessage.Text = registerUser.CreateLoginAccount(Name, RoleId, password, confirmPassword);
    }


}

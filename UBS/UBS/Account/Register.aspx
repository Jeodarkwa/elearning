<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs"
    Inherits="Account_Register" %>


<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Use the form below to create a new account.</h2>
    </hgroup>


    <p class="message-info">
        Passwords are required to be a minimum of <%: Membership.MinRequiredPasswordLength %> characters in length.
    </p>

    <p class="validation-summary-errors">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>


    <legend>Registration Form</legend>
    <table>
        <tr>


            <td>
                <asp:Label runat="server" ID="lbName">Name</asp:Label>
                <asp:TextBox runat="server" ID="txtName" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName"
                    CssClass="field-validation-error" ErrorMessage="The Name field is required." />
            </td>

            <td>
                <asp:Label runat="server" ID="lbSirName">Sir Name</asp:Label>
                <asp:TextBox runat="server" ID="txtSirName" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtSirName"
                    CssClass="field-validation-error" ErrorMessage="The Sir Name field is required." />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lbEmail">Email address</asp:Label>
                <asp:TextBox runat="server" ID="txtEmail" TextMode="SingleLine" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtEmail"
                    CssClass="field-validation-error" ErrorMessage="The email address field is required." />
            </td>

            <td>
                <asp:Label runat="server" ID="lbAddress">Address</asp:Label>
                <asp:TextBox runat="server" ID="txtAddress" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtAddress"
                    CssClass="field-validation-error" ErrorMessage="The Address field is required." />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lbCountry">Country</asp:Label>
                <asp:TextBox runat="server" ID="txtCountry" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtCountry"
                    CssClass="field-validation-error" ErrorMessage="The Country field is required." />
            </td>

            <td>
                <asp:Label runat="server" ID="lbTelephone">Telephone No.</asp:Label>
                <asp:TextBox runat="server" ID="txtTelephone" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lbMobile">Mobile No.</asp:Label>
                <asp:TextBox runat="server" ID="txtMobile" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtMobile"
                    CssClass="field-validation-error" ErrorMessage="The Mobile field is required." />
            </td>
            <td>
                <asp:Label runat="server" ID="lbBirthDate">Date of Birth</asp:Label>
                <asp:TextBox runat="server" ID="txtBirthDate" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtBirthDate"
                    CssClass="field-validation-error" ErrorMessage="The Date of Birth field is required." />
            </td>
        </tr>

        
        <tr>
            <td>
                <asp:Label runat="server" ID="lbOcuupation">Ocuupation</asp:Label>
                <asp:TextBox runat="server" ID="txtOcuupation" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtOcuupation"
                    CssClass="field-validation-error" ErrorMessage="The Ocuupation field is required." />
            </td>
            <td>
                <asp:Label runat="server" ID="lbDenomination">Denomination</asp:Label>
                <asp:TextBox runat="server" ID="txtDenomination" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtDenomination"
                    CssClass="field-validation-error" ErrorMessage="The Denomination field is required." />
            </td>
        </tr>

        
        <tr>
            <td>
                <asp:Label runat="server" ID="Label1">Role</asp:Label>
                <asp:DropDownList ID="ddlRole" runat="server">
                    <asp:ListItem Text="Student" Value="4"></asp:ListItem>
                    <asp:ListItem Text="Teacher" Value="3"></asp:ListItem>
                    <asp:ListItem Text="Administrator" Value="2"></asp:ListItem>
                    <asp:ListItem Text="Others" Value="5"></asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="ddlRole"
                    CssClass="field-validation-error" ErrorMessage="The Role field is required." />
            </td>
            <td>
                <asp:Label runat="server" ID="lbMarriageStatus">Marriage Status</asp:Label>
                <asp:DropDownList ID="ddlMarriageStatus" runat="server">
                    <asp:ListItem Text="Single" Value="1"></asp:ListItem>
                    <asp:ListItem Text="Married" Value="2"></asp:ListItem>
                    <asp:ListItem Text="Divorced" Value="3"></asp:ListItem>
                    <asp:ListItem Text="Others" Value="4"></asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="ddlMarriageStatus"
                    CssClass="field-validation-error" ErrorMessage="The Marriage Status is required." />
            </td>
           
        </tr>

        <tr>
            <td>
                <asp:Label runat="server" ID="lbPassword">Password</asp:Label>
                <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPassword"
                    CssClass="field-validation-error" ErrorMessage="The password field is required." />
            </td>

            <td>
                <asp:Label runat="server" ID="lbConfirmPassword">Confirm password</asp:Label>
                <asp:TextBox runat="server" ID="txtConfirmPassword" TextMode="Password" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtConfirmPassword"
                    CssClass="field-validation-error" Display="Dynamic" ErrorMessage="The confirm password field is required." />
                <asp:CompareValidator runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword"
                    CssClass="field-validation-error" Display="Dynamic" ErrorMessage="The password and confirmation password do not match." />
            </td>
            <%--  
                <asp:Label runat="server" ID="lbUserName">User name</asp:Label>
                <asp:TextBox runat="server" ID="txtUserName" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtUserName"
                    CssClass="field-validation-error" ErrorMessage="The user name field is required." />
         --%>

        </tr>
    </table>

    <asp:Button runat="server" ID="confermRegistration" Text="Register" OnClick="confermRegistration_Click" />

</asp:Content>

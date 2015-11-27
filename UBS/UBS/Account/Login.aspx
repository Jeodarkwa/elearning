<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" MasterPageFile="~/MasterPage.master"
     Inherits="Account_Login" %>


<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %></h1>
    </hgroup>
    <section id="loginForm">

        <h2>Use a local account to log in.</h2>
       <p class="validation-summary-errors">
                        <asp:Literal runat="server" ID="ErrorMessage" />
                    </p>
           
                    <ol>
                        <li>
                            <asp:Label runat="server" ID="lbUserName">User name</asp:Label>
                            <asp:TextBox runat="server" ID="txtUserName" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserName" CssClass="field-validation-error" ErrorMessage="The user name field is required." />
                        </li>
                        <li>
                            <asp:Label runat="server" ID="lbPassword">Password</asp:Label>
                            <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" CssClass="field-validation-error" ErrorMessage="The password field is required." />
                        </li>
                        <li>
                            <asp:CheckBox runat="server" ID="RememberMe" />
                            <asp:Label ID="Label1" runat="server" AssociatedControlID="RememberMe" CssClass="checkbox">Remember me?</asp:Label>
                        </li>
                    </ol>
                      <asp:Button runat="server" ID="btnLogin" Text="Log in" OnClick="btnLogin_Click" />


                <p>
            <asp:HyperLink runat="server" ID="RegisterHyperLink" ViewStateMode="Disabled">Register</asp:HyperLink>
            if you don't have an account.
        </p>

    </section>

    <section id="socialLoginForm">
        <h2>Use another service to log in.</h2>
       
    </section>
</asp:Content>


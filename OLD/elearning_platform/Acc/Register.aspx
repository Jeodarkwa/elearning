<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master"  CodeBehind="Register.aspx.cs" Inherits="elearning_platform.Acc.Register" %>

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
                        <ol>
                            <li>
                                <asp:Label runat="server" ID="lbUserName">User name</asp:Label>
                                <asp:TextBox runat="server" ID="txtUserName" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtUserName"
                                    CssClass="field-validation-error" ErrorMessage="The user name field is required." />
                            </li>
                            <li>
                                <asp:Label runat="server" ID="lbEmail">Email address</asp:Label>
                                <asp:TextBox runat="server" ID="txtEmail" TextMode="Email" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtEmail"
                                    CssClass="field-validation-error" ErrorMessage="The email address field is required." />
                            </li>
                            <li>
                                <asp:Label runat="server" ID="lbPassword">Password</asp:Label>
                                <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPassword"
                                    CssClass="field-validation-error" ErrorMessage="The password field is required." />
                            </li>
                            <li>
                                <asp:Label runat="server" ID="lbConfirmPassword">Confirm password</asp:Label>
                                <asp:TextBox runat="server" ID="txtConfirmPassword" TextMode="Password" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtConfirmPassword"
                                     CssClass="field-validation-error" Display="Dynamic" ErrorMessage="The confirm password field is required." />
                                <asp:CompareValidator runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword"
                                     CssClass="field-validation-error" Display="Dynamic" ErrorMessage="The password and confirmation password do not match." />
                            </li>
                        </ol>
                        <asp:Button runat="server" ID="confermRegistration" Text="Register" OnClick="confermRegistration_Click" />
                        
                        </asp:Content>
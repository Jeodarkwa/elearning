<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Exams.aspx.cs" Inherits="elearning_platform.About" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>

        <h2>This page contains the questions for exams </h2>
    </hgroup>

    <article>
        
        <Div class="questionBox">         
           <h2>1.  This is the First Question, Please choose your answer</h2> 
            <asp:CheckBoxList runat="server" ID="question1List">
                <asp:ListItem Value="A">This is answer A</asp:ListItem>
                
                <asp:ListItem Value="B">This is answer B</asp:ListItem>
                <asp:ListItem Value="C">This is answer C</asp:ListItem>
                <asp:ListItem Value="D">This is answer D</asp:ListItem>
                
            </asp:CheckBoxList>
            <br />
        </div>



        
       
        <Div class="questionBox">          
          <h2>2. This is the second Question, Please choose your answer</h2> 
            <asp:CheckBoxList runat="server" ID="question2List">
                <asp:ListItem Value="A">This is answer A</asp:ListItem>
                
                <asp:ListItem Value="B" >This is answer B</asp:ListItem>
                <asp:ListItem Value="C">This is answer C</asp:ListItem>
                <asp:ListItem Value="D">This is answer D</asp:ListItem>
                
            </asp:CheckBoxList>
            <br />
        </div>



        
        <Div class="questionBox">        
          <h2>3.  This is the third Question, Please choose your answer</h2> 
            <asp:CheckBoxList runat="server" ID="question3List">
                <asp:ListItem Value="A">This is answer A</asp:ListItem>
                
                <asp:ListItem Value="B">This is answer B</asp:ListItem>
                <asp:ListItem Value="C">This is answer C</asp:ListItem>
                <asp:ListItem Value="D">This is answer D</asp:ListItem>
                
            </asp:CheckBoxList>

        </Div>

        <br />
        <asp:Button ID="btn_submit" runat="server" Text="Submit Solution" />
            
                </article>

    <aside>
        <h3>Exams code</h3>
        <p>        
            Return to Home after Exams
        </p>
        <ul>
            <li><a runat="server" href="~/">Home</a></li>
            <li><a runat="server" href="~/About">About</a></li>
            <li><a runat="server" href="~/Contact">Contact</a></li>
        </ul>
    </aside>
</asp:Content>
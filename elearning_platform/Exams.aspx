<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Exams.aspx.cs" Inherits="elearning_platform.About" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>

        <h2>This page contains the questions for exams </h2>
    </hgroup>

    <article>
       <%-- Question Repeater--%>
        <asp:repeater id="RptQuestions" runat="server">
            <ItemTemplate>
                <%#DataBinder.Eval(Container.DataItem, "Exmas_Question.Examquestion" )%>
                <ul>
                     <li><asp:checkbox id="chkbxQt1" runat="server" /> <%#Eval("Exmas_Question.solution1")%></li>
                     <li><asp:checkbox id="chkbxQt2" runat="server" /> <%#Eval("Exmas_Question.solution2")%></li>
                     <li><asp:checkbox id="chkbxQt4" runat="server" /> <%#Eval("Exmas_Question.solution3")%></li>

                    </ul>
            </ItemTemplate>
            <SeparatorTemplate>
                &nbps
            </SeparatorTemplate>
            <AlternatingItemTemplate>
                 <%#DataBinder.Eval(Container.DataItem, "Exmas_Question.Examquestion" )%>
                <ul>
                     <li><asp:checkbox id="chkbxQt1" runat="server" /> <%#Eval("Exmas_Question.solution1")%></li>
                     <li><asp:checkbox id="chkbxQt2" runat="server" /> <%#Eval("Exmas_Question.solution2")%></li>
                     <li><asp:checkbox id="chkbxQt4" runat="server" /> <%#Eval("Exmas_Question.solution3")%></li>
                    </ul>
            </AlternatingItemTemplate>

         </asp:repeater>


        <br />
        <asp:Button ID="btn_submit" runat="server" Text="Submit Solution" OnClick="btn_submit_Click" />
            <asp:Label ID="lblResults" runat="server"></asp:Label>
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

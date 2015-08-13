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
                
                  <asp:Label ID="lblExQuestions" runat="server" Text=<%#DataBinder.Eval(Container.DataItem, "Exmas_Question.Examquestion" )%>/> 
                
                <ul>
                     <li>A <asp:checkbox id="chkbxQt1" runat="server" Text=<%#DataBinder.Eval(Container.DataItem, "Exmas_Question.solution1" )%>/> 
                       </li>
                     <li>B <asp:checkbox id="chkbxQt2" runat="server" Text=<%#DataBinder.Eval(Container.DataItem, "Exmas_Question.solution2" )%>/> 
                       </li>
                     <li>C <asp:checkbox id="chkbxQ3" runat="server" Text=<%#DataBinder.Eval(Container.DataItem, "Exmas_Question.solution3" )%>/> 
                       </li>
                </ul>
                      
                      
            </ItemTemplate>
            <SeparatorTemplate>
             &nbsp;
            </SeparatorTemplate>
            <AlternatingItemTemplate>
                
                   <asp:Label ID="lblExQuestions" runat="server" Text=<%#DataBinder.Eval(Container.DataItem, "Exmas_Question.Examquestion" )%>/> 
                
                <ul>
                     <li>A <asp:checkbox id="chkbxQt1" runat="server" Text=<%#DataBinder.Eval(Container.DataItem, "Exmas_Question.solution1" )%>/> 
                       </li>
                     <li>B <asp:checkbox id="chkbxQt2" runat="server" Text=<%#DataBinder.Eval(Container.DataItem, "Exmas_Question.solution2" )%>/> 
                       </li>
                     <li>C <asp:checkbox id="chkbxQt3" runat="server" Text=<%#DataBinder.Eval(Container.DataItem, "Exmas_Question.solution3" )%>/> 
                       </li>
                </ul>
                      
            </AlternatingItemTemplate>
         </asp:repeater>


        <br />
        <asp:Button ID="btn_submit" runat="server" Text="Submit Solution" OnClick="btn_submit_Click" />
            <asp:Label ID="lblResults" runat="server"></asp:Label>



      <asp:Repeater id="repRoles" runat="server">
       <ItemTemplate>
              <asp:literal ID="Literal1" runat="server" text=<%# DataBinder.Eval(Container.DataItem, "ItemTitle") %>></asp:literal>
              <br />
              <asp:CheckBoxList ID="CheckBoxList1" runat="server" DataSource=<%# (DataBinder.Eval(Container.DataItem,"")) %> 
                                    DataTextField="ItemName" DataValueField="ItemValue">
              </asp:CheckBoxList>
       </ItemTemplate>
</asp:Repeater>
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

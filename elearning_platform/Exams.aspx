<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Exams.aspx.cs" Inherits="elearning_platform.About" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>

        <h2>This page contains the questions for exams </h2>
    </hgroup>

    <article>
        <%-- Question Repeater--%>
        <asp:Repeater ID="RptQuestions" runat="server">
            <ItemTemplate>

                <asp:Label ID="lblExQuestions" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "Exmas_Question.Question" )%>' />
                <ul>

                     <li>A <asp:checkbox id="chkbxQ" runat="server" Text=<%#DataBinder.Eval(Container.DataItem, "Exmas_Question.multiplechoice1" )%>/> 
                       </li>
                     <li>B <asp:checkbox id="chkbxQt" runat="server" Text=<%#DataBinder.Eval(Container.DataItem, "Exmas_Question.multiplechoice2" )%>/> 
                       </li>
                     <li>C <asp:checkbox id="chkbxQtt" runat="server" Text=<%#DataBinder.Eval(Container.DataItem, "Exmas_Question.multiplechoice3" )%>/> 
                       </li>

                </ul>


            </ItemTemplate>
            <SeparatorTemplate>
                &nbsp;
            </SeparatorTemplate>
            <AlternatingItemTemplate>

                   <asp:Label ID="lblExQuestions" runat="server" Text=<%#DataBinder.Eval(Container.DataItem, "Exmas_Question.Question" )%>/> 
                
                    <ul>
                     <li>A <asp:checkbox id="chkbxQ" runat="server" Text=<%#DataBinder.Eval(Container.DataItem, "Exmas_Question.multiplechoice1" )%>/> 
                       </li>
                     <li>B <asp:checkbox id="chkbxQt" runat="server" Text=<%#DataBinder.Eval(Container.DataItem, "Exmas_Question.multiplechoice2" )%>/> 
                       </li>
                     <li>C <asp:checkbox id="chkbxQtt" runat="server" Text=<%#DataBinder.Eval(Container.DataItem, "Exmas_Question.multiplechoice3" )%>/> 
                       </li>
                </ul>     
            </AlternatingItemTemplate>
        </asp:Repeater>


        <br />
        <asp:Button ID="btn_submit" runat="server" Text="Submit Solution" OnClick="btn_submit_Click" />
        <asp:Label ID="lblResults" runat="server"></asp:Label>



        <asp:Repeater ID="repRoles" runat="server">
            <ItemTemplate>
                <asp:Literal ID="Literal1" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ItemTitle") %>'></asp:Literal>
                <br />
                <asp:CheckBoxList ID="CheckBoxList1" runat="server" DataSource='<%# (DataBinder.Eval(Container.DataItem,"")) %>'
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

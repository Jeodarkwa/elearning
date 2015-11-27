<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Exam.aspx.cs" Inherits="Exams_Exam"
    MasterPageFile="~/MasterPage.master" %>


<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>This page contains the questions for exams </h2>
    </hgroup>


    <div style="float: left">
        <asp:Label ID="lblInsExamsID" Text=" Insert Exams ID:" runat="server"></asp:Label><asp:TextBox ID="txtQuestionID" runat="server"></asp:TextBox>
    </div>


    <div style="float: left">
        <asp:Label ID="lblInsStudentID" Text="Insert Student ID:" runat="server"></asp:Label>
        <asp:TextBox ID="TxtStudentID" runat="server"></asp:TextBox>
    </div>


    <div class="ClearAll"></div>
    <div style="align-content: center;">

        <asp:Button runat="server" Text="Submit Dates" ID="btnSubmitStEx" OnClick="txtQuestionID_TextChanged" />
    </div>

    <article>


        <asp:GridView ID="grdExams" runat="server" AllowPaging="false"
            AllowSorting="false"
            AutoGenerateColumns="false"
            CellPadding="4"
            GridLines="None" Width="100%" AllowCustomPaging="true">

            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <%# Eval("Exmas_Question.QuestionID") %>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField>

                    <ItemTemplate>
                        <%# Eval("Exmas_Question.ExamsQuestion") %>

                        <ol type="A">
                            <li>
                                <asp:CheckBox ID="chkbxA" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "Exmas_Question.multiplechoice1" )%>' />
                            </li>
                            <li>
                                <asp:CheckBox ID="chkbxB" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "Exmas_Question.multiplechoice2" )%>' />
                            </li>
                            <li>
                                <asp:CheckBox ID="chkbxC" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "Exmas_Question.multiplechoice3" )%>' />
                            </li>
                            <li>
                                <asp:CheckBox ID="chkbxD" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "Exmas_Question.multiplechoice4" )%>' />
                            </li>
                            <li>
                                <asp:CheckBox ID="chkbxE" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "Exmas_Question.multiplechoice5" )%>' />
                            </li>
                        </ol>
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>


            <RowStyle BackColor="#000000" BorderColor="WindowFrame" ForeColor="White" />
            <AlternatingRowStyle BackColor="#99FFCC" ForeColor="#284775" />

        </asp:GridView>
        <div class="buttons mt10">
            <button id="btnSave" runat="server">
            </button>
        </div>
        <asp:Button ID="btn_submit" runat="server" Text="Submit Solution" OnClick="btn_submit_Click" />
        <asp:Label ID="lblResults" runat="server"></asp:Label>
    </article>

    <aside>
        <h3>Exams code</h3>
        <p>
            Return to Home after Exams
        </p>
        <ul>
            <li><a id="A1" runat="server" href="~/">Home</a></li>
            <li><a id="A2" runat="server" href="~/About">About</a></li>
            <li><a id="A3" runat="server" href="~/Contact">Contact</a></li>
        </ul>
    </aside>

</asp:Content>

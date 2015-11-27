<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StudentPage.aspx.cs" Inherits="Student_StudentPage"
    MasterPageFile="~/MasterPage.master" %>


<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
                <h2>this is the home page</h2>
            </hgroup>
        </div>
    </section>
</asp:Content>


<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">


    <section class="content-wrapper">
        <h3>This is going to contain any thing you want to place in the home page</h3>
        <table>
            <tbody>
                <tr>
                    <td>Name:</td>
                    <td>
                        <asp:Label ID="lblStName" runat="server" /></td>
                </tr>
                <tr>
                    <td>Student Number:</td>
                    <td>
                        <asp:Label ID="lblStudentId" runat="server" /></td>
                </tr>
                <tr>
                    <td>Place of Course:</td>
                    <td>
                        <asp:Label ID="lblPlaceOfCourse" runat="server" /></td>
                </tr>

                <tr>
                    <td>Ref Teacher:</td>
                    <td>
                        <asp:Label ID="lblTeacher" runat="server" /></td>
                </tr>

            </tbody>
        </table>
    </section>

    <section class="content-wrapper">



        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"
            BorderWidth="1px" BackColor="White" GridLines="Vertical"
            CellPadding="4" BorderStyle="None"
            BorderColor="#DEDFDE" ForeColor="Black">
            <FooterStyle BackColor="#CCCC99"></FooterStyle>
            <PagerStyle ForeColor="Black" HorizontalAlign="Right"
                BackColor="#F7F7DE"></PagerStyle>
            <HeaderStyle ForeColor="White" Font-Bold="True"
                BackColor="#6B696B"></HeaderStyle>
            <AlternatingRowStyle BackColor="White"></AlternatingRowStyle>
            <Columns>

                <asp:TemplateField HeaderText="Course ID">

                    <ItemTemplate>
                       <%# Eval("Exmas_Question.QuestionID") %>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Course Name">
                    <ItemTemplate>
                      <%# Eval("Exmas_Question.QuestionID") %>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Exams State">
                    <ItemTemplate>
                        <%# Eval("Exmas_Question.QuestionID") %>
                    </ItemTemplate>
                </asp:TemplateField>


                <asp:TemplateField HeaderText="Scores">
                    <ItemTemplate>
                       <%# Eval("Exmas_Question.QuestionID") %>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Notes">
                    <ItemTemplate>
                         <%# Eval("Exmas_Question.QuestionID") %>
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>
            <SelectedRowStyle ForeColor="White" Font-Bold="True"
                BackColor="#CE5D5A"></SelectedRowStyle>
            <RowStyle BackColor="#F7F7DE"></RowStyle>
        </asp:GridView>
    </section>


</asp:Content>

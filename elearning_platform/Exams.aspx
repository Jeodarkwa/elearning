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


        <!-- gridview -->
        <%--     OnRowDataBound="grvSOTickets_RowDataBound"  OnRowCommand="grvSOTickets_RowCommand" --%>

        <asp:GridView ID="grvNightTruck" runat="server"  Visible="false"
                    AutoGenerateColumns="False"
                    DataKeyNames="ServiceOrderTicketPK"
                   
                
                    EnableTheming="False">
                    <HeaderStyle CssClass="HeaderStyle"  ForeColor="White" />
                    <Columns>
                        <asp:ButtonField ButtonType="Image" ImageUrl="~/Images/Buttons/right_arrow.gif" CommandName="Select" Text="Expand" ItemStyle-CssClass="GridColumnsText"/>
                        <asp:TemplateField HeaderText="" ItemStyle-CssClass="GridColumnsText">
                            <HeaderTemplate>
                                <table cellpadding="2" cellspacing="0" border="0" width="640px">
                                    <tr>
                                       <%-- <td width="25px"><asp:CheckBox ID="chkAll" runat="server" OnCheckedChanged="chkAll_OnCheckedChanged" AutoPostBack="true"/></td> --%>
                                        <td width="35px" align="left">Truck</td>
                                        <td width="35px" align="left">Miles</td>
                                        <td width="100px" align="left">Sections</td>
                                        <td width="100px" align="left">Tecnician</td>
                                        <td width="345px" align="left">Instructions</td>
                                    </tr>
                                </table>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <table cellpadding="2" cellspacing="0" border="0" width="640px">
                                    <tr>
                                        <td width="25px" align="left" valign="top">
                                            <asp:CheckBox ID="chkSOTicket" runat="server" checked='<%# Bind("IsChecked") %>' OnCheckedChanged="chkSOTicket_OnCheckedChanged" AutoPostBack="true" />
                                        </td>
                                        <td width="35px" align="left" valign="top">
                                            <asp:Label ID="lblMapNumber" runat="server" Text='<%# Eval("TruckNumber") %>' />
                                        </td>
                                        <td width="35px" align="left" valign="top">
                                            <asp:Label ID="lblMileage" runat="server" Text='<%# Eval("Mileage") %>' />
                                        </td>
                                        <td width="100px" align="left" valign="top">
                                            <asp:Label ID="lblLocationCount" runat="server" Text='<%# Eval("TruckSections") %>' />
                                        </td>
                                        <td width="100px" align="left" valign="top">
                                           <%-- <asp:DropDownList ID="ddlTechnicianSOT" runat="server" DataSource='<%# PopulateTechnicianDDL(DataBinder.Eval(Container.DataItem, "ServiceOrderPK").ToString()) %>' DataTextField="FullName" DataValueField="TechnicianPK"  SelectedValue='<%# Bind("TechnicianPK") %>' OnSelectedIndexChanged="ddlTechnicianSOT_OnSelectedIndexChanged" AutoPostBack="true"/> --%>
                                        </td>
                                        <td width="345px" align="left" valign="top">
                                            <asp:TextBox ID="txtInstructionsSOT" runat="server" Text='<%# Bind("Instruction") %>'  TextMode="MultiLine" Width="100%" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="6">
                                            <%--   OnRowDataBound="grvSOTLocations_RowDataBound" --%>
                                            <asp:GridView ID="grvSOTLocations" runat="server" Visible="False"
                                                CssClass="GridViewStyle"
                                                DataKeyNames="ServiceOrderTicketLocationPK,CompletionCount,Direction"
                                                AllowSorting="false"
                                              
                                                EnableTheming="False" AutoGenerateColumns="false" CellPadding="4">
                                                <HeaderStyle BackColor="LightGray" ForeColor="Black" />
                                                <Columns>
                                                    <asp:TemplateField ItemStyle-CssClass="GridColumnsText">
                                                        <ItemTemplate>
                                                            <asp:CheckBox ID="chkSOTLocation" runat="server" onclick="chkSOTLocation_onclick(this);"/>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Seq" ItemStyle-CssClass="GridColumnsText" SortExpression="Sequence">
                                                        <ItemTemplate>
                                                            <asp:TextBox ID="txtSequence" runat="server" Width="20"/>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Truck" ItemStyle-CssClass="GridColumnsText" SortExpression="SectionDescription">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblSectionDescription" runat="server" Text='<%# Bind("SectionDescription") %>' />
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Sec" ItemStyle-CssClass="GridColumnsText" SortExpression="LocationDescription">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblLocationDescription" runat="server" Text='<%# Bind("LocationDescription") %>' />
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Miles" ItemStyle-CssClass="GridColumnsText" SortExpression="Mileage">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblMileage" runat="server" Text='<%# Bind("Mileage") %>' />
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Direction" ItemStyle-CssClass="GridColumnsText" SortExpression="Direction">
                                                        <ItemTemplate>
                                                            <asp:Label Visible="false" ID="lblDropDownList" runat="server" Text='<%# Bind("Direction") %>'/>
                                                            <asp:DropDownList ID="ddlDirection" runat="server" SelectedValue='<%# Bind("Direction") %>' Width="60">
                                                              <asp:ListItem Value="Start" Text="Start" />
                                                              <asp:ListItem Value="End" Text="End" />
                                                            </asp:DropDownList>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Cnt" ItemStyle-CssClass="GridColumnsText" SortExpression="CompletionCount">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblCompletionCount" runat="server" Text='<%# Bind("CompletionCount") %>' />
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Date" ItemStyle-CssClass="GridColumnsText" SortExpression="TreatmentDate">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblTreatmentDate" runat="server" Text='<%# Bind("TreatmentDate") %>' />
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Cust&nbsp;Id" ItemStyle-CssClass="GridColumnsText" SortExpression="CustomerSiteID">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblCustomerSiteID" runat="server" Text='<%# Bind("CustomerSiteID") %>' />
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Description" ItemStyle-CssClass="GridColumnsText" SortExpression="CustomerSiteDescription">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblCustomerSiteDescription" runat="server" Text='<%# Bind("CustomerSiteDescription") %>' />
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Technician" ItemStyle-CssClass="GridColumnsText">
                                                        <ItemTemplate>
                                                           <%-- <asp:DropDownList ID="ddlTechnicianSOTL" runat="server" DataSource='<%# PopulateTechnicianDDL(DataBinder.Eval(Container.DataItem, "ServiceOrderPK").ToString()) %>' DataTextField="FullName" DataValueField="TechnicianPK"  SelectedValue='<%# Bind("TechnicianPK") %>' onchange="ddlTechnicianSOTL_onchange(this);" /> --%>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                </Columns>
                                            </asp:GridView>
                                       </td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <EditRowStyle Wrap="False" />
                </asp:GridView>






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
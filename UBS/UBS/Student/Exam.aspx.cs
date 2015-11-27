using ElearningPlatform.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Exams_Exam : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (FormsAuthentication.IsEnabled)

            btn_submit.Text = HttpContext.Current.User.Identity.Name;

        IExamsBLL newExams = ServiceLocator.GetCurrentBLLFactory().BuildExamsBLL();
        newExams.ExamQuestionsNSolutionGet(4);
            
        
    }


    public int getExamsID()
    {
        string qtIdString = txtQuestionID.Text;
        int questID = 0;
        if (!String.IsNullOrEmpty(qtIdString))
        {
            questID = int.Parse(qtIdString);
        }

        return questID;
    }


    public int getStudentID()
    {
        string qtIdString = TxtStudentID.Text;
        int studentID = 0;
        if (!String.IsNullOrEmpty(qtIdString))
        {
            studentID = int.Parse(qtIdString);

        }

        return studentID;
    }

    public IList<IExams> ExamsQuestions()
    {
        IList<IExams> ExamQuestions = new List<IExams>();

        IExamsBLL newExams = ServiceLocator.GetCurrentBLLFactory().BuildExamsBLL();


        if (getExamsID() > 0)
            ExamQuestions = newExams.GetExamsByIDs(getExamsID());

        return ExamQuestions;
    }

    /// <summary>
    /// Bind the question Data
    /// </summary>
    private void CreateExams()
    {

        grdExams.DataSource = ExamsQuestions();
        grdExams.DataBind();

    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btn_submit_Click(object sender, EventArgs e)
    {
        IList<IExams> studentAnswers = new List<IExams>();

        //foreach (RepeaterItem reptItem in RptQuestions.Items)
        //{

        //    IExams studentAnswer = DAOFactory.BuildExamsDAO();


        //    IQuestion examsQuestions = DAOFactory.BuildQuestionDAO();

        //    if (reptItem.ItemIndex <= 0)
        //    {
        //        Label examsIDLable = (Label)reptItem.FindControl("lblExsID");

        //        string exmsID = examsIDLable.Text;
        //        if (!String.IsNullOrEmpty(exmsID))
        //            studentAnswer.ExamsID = int.Parse(exmsID);
        //    }

        //    CheckBox chkbxA = (CheckBox)reptItem.FindControl("chkbxA");
        //    Label lbQtID_A = (Label)reptItem.FindControl("lbQtID_A");
        //    if (chkbxA.Checked)
        //    {
        //        examsQuestions.selectedAnswer = 'a';
        //        string questionIdLblA = lbQtID_A.Text;
        //        examsQuestions.QuestionID = int.Parse(questionIdLblA);
        //    }

        //    CheckBox chkbxB = (CheckBox)reptItem.FindControl("chkbxB");
        //    Label lbQtID_B = (Label)reptItem.FindControl("lbQtID_B");
        //    if (chkbxB.Checked)
        //    {
        //        examsQuestions.selectedAnswer = 'b';
        //        string questionIdLblB = lbQtID_B.Text;
        //        examsQuestions.QuestionID = int.Parse(questionIdLblB);
        //    }

        //    CheckBox chkbxC = (CheckBox)reptItem.FindControl("chkbxC");
        //    Label lbQtID_C = (Label)reptItem.FindControl("lbQtID_C");
        //    if (chkbxC.Checked)
        //    {
        //        examsQuestions.selectedAnswer = 'c';
        //        string questionIdLblC = lbQtID_C.Text;
        //        examsQuestions.QuestionID = int.Parse(questionIdLblC);
        //    }
        //    studentAnswer.Exmas_Question = examsQuestions;
        //    studentAnswers.Add(studentAnswer);
        //}

        //IExamsBLL examsSolu = ServiceLocator.GetCurrentBLLFactory().BuildExamsBLL();


        //int Totesults = examsSolu.correctExam(studentAnswers, getStudentID());

        //// Totesults = getStudentID(); 
        //lblResults.Text = "No of checked records is " + Totesults.ToString();
        //btn_submit.Visible = false;
    }

    protected void txtQuestionID_TextChanged(object sender, EventArgs e)
    {
        CreateExams();
       // populateRptQuestions();
        txtQuestionID.Visible = false;
        TxtStudentID.Visible = false;
        btnSubmitStEx.Visible = false;
        btn_submit.Visible = true;
        lblInsExamsID.Visible = false;
        lblInsStudentID.Visible = false;
    }
}

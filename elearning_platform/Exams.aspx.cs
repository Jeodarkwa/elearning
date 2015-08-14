using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CORE.DAO; 


namespace elearning_platform
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            populateRptQuestions();
        }

        public List<Exams> ExamsQuestions()
        {
            List<Exams> ExamQuestions = new List<Exams>(); 
            for (Int16 i = 1; i < 10; i++)
            {
                Exams newExams = new Exams();
                Questions newQuestions = new Questions();
                newQuestions.Examquestion = i + ". This is the first " + i + " question";
                newQuestions.solution1 = "choose A";
                newQuestions.solution2 = "Choose B";
                newQuestions.solution3 = "Choose C";
                newQuestions.Question_ID = i;
                newExams.Exams_ID = i;
                newExams.Exmas_Question = newQuestions; 
                ExamQuestions.Add(newExams);
            }

            return ExamQuestions;  
        }



        private void populateRptQuestions()
        {
            RptQuestions.DataSource = ExamsQuestions();
           

            RptQuestions.DataBind();
        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            String counter = null;
            foreach (RepeaterItem reptItem in RptQuestions.Items)
            {
                var dtItem = reptItem.ClientID;  

                CheckBox chkbxQ = (CheckBox)reptItem.FindControl("chkbxQ");
                if (chkbxQ.Checked)
                    counter = chkbxQ.Text;

                CheckBox chkbxW = (CheckBox)reptItem.FindControl("chkbxQt");
                if (chkbxW.Checked)
                    counter = chkbxW.Text;

                CheckBox chkbxR = (CheckBox)reptItem.FindControl("chkbxQtt");
                if (chkbxR.Checked)
                    counter = chkbxR.Text;

              
            
            }

            lblResults.Text = "No of checked records is " + counter;
        }




    }
}
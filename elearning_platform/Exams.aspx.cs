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
            for (Int16 i = 1; i < 4; i++)
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
                CheckBox chkbx1 = (CheckBox)reptItem.FindControl("chkbxQt1");
                if (chkbx1.Checked)
                    counter = chkbx1.Text;

                CheckBox chkbx2 = (CheckBox)reptItem.FindControl("chkbxQt2");
                if (chkbx2.Checked)
                    counter = chkbx2.Text;

               // CheckBox chkbx3 = (CheckBox)reptItem.FindControl("chkbxQt3");
               // if (chkbx3.Checked)
                   // counter = chkbx3.Text;
            
            }

            lblResults.Text = "No of checked records is " + counter;
        }




    }
}
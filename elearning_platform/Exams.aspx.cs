using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUSINESS_LAYER.EXAMSCORE; 
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
            for (Int16 i = 1; i < 3; i++)
            {
                Exams newExams = new Exams();
                Questions newQuestions = new Questions();
                newQuestions.Question = i + ". This is the first " + i + " question";
                newQuestions.multiplechoice1 = "choose A";
                newQuestions.multiplechoice2 = "Choose B";
                newQuestions.multiplechoice3 = "Choose C";
                newQuestions.Question_ID = i;
                newExams.Exams_ID = i;
                newExams.Exmas_Question = newQuestions; 
                ExamQuestions.Add(newExams);
            }

            return ExamQuestions;  
        }


        /// <summary>
        /// Bind the question Data
        /// </summary>
        private void populateRptQuestions()
        {
            RptQuestions.DataSource = ExamsQuestions();
            RptQuestions.ID = "exams34";
            RptQuestions.DataBind();
        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            String counter = null;

            int RptItCount = RptQuestions.Items.Count;
            string[] chsAnswers = new string[RptItCount];
         //  List<string[]> selectedAnswes = new List<string[]>();

            String examsID = RptQuestions.ID; 
               foreach (RepeaterItem reptItem in RptQuestions.Items)
               {

                   int i = reptItem.ItemIndex; 

                   CheckBox chkbxQ = (CheckBox)reptItem.FindControl("chkbxQ");
                   if (chkbxQ.Checked)
                   {
                       counter = chkbxQ.Text;
                       chsAnswers[i] = "a";
                   }

                   CheckBox chkbxW = (CheckBox)reptItem.FindControl("chkbxQt");
                   if (chkbxW.Checked)
                   {
                       counter = chkbxQ.Text;
                       chsAnswers[i] = "b";
                   }

                   CheckBox chkbxR = (CheckBox)reptItem.FindControl("chkbxQtt");
                   if (chkbxR.Checked)
                   {
                       counter = chkbxQ.Text;
                       chsAnswers[i] = "c";
                   }

                   counter = null;

                   //selectedAnswes.Add(questions);
               }

            BLL_Exams exams = new BLL_Exams();

            int[] exResults = exams.correctExam(chsAnswers, 3);

            lblResults.Text = "No of checked records is " + counter;
        }




    }
}
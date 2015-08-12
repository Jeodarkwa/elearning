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
            populateGridQuestions();
        }



        private List<Exams> ExamsQuestions()
        {
           
            Exams newExams = new Exams();
            Questions newQuestions = new Questions();
            List<Exams> ExamQuestions = new List<Exams>(); 


            for (Int16 i = 1; i < 4; i++)
            {
                newQuestions._questions = i +"this is just a questions";
                newQuestions.Question_ID = i;

                newExams.Exams_ID = i;
                newExams.Exmas_Question = newQuestions; 
            //    newExams.Exmas_Question._questions = i + "this is just a questions";
              //  newExams.Exmas_Question = newQuestions.;

                ExamQuestions.Add(newExams);
            }


            return ExamQuestions;  
        }



        private void populateGridQuestions()
        {

            rpResults.DataSource = ExamsQuestions();
            
            rpResults.DataBind();
           

            /*  grvNightTruck.DataSource = ExamsQuestions();
              grvNightTruck.DataBind(); */

        }


        protected void chkSOTicket_OnCheckedChanged(object sender, EventArgs e)
        {
            DateTime start = DateTime.Now;
           // logger.Debug("BEGIN chkSOTicket_OnCheckedChanged: " + start);

            CheckBox chkSOTicket = (CheckBox)sender;
            GridViewRow gridViewRowSOT = (GridViewRow)chkSOTicket.Parent.Parent;

            if (!chkSOTicket.Checked)
            {
                DropDownList ddlTechnicianSOT = (DropDownList)gridViewRowSOT.FindControl("ddlTechnicianSOT");
               // ddlTechnicianSOT.SelectedValue = Utils.NULL_INT.ToString();
            }

            GridView gvSOTLocations = (GridView)gridViewRowSOT.FindControl("grvSOTLocations");

            foreach (GridViewRow gridViewRowSOTL in gvSOTLocations.Rows)
            {
                if (gridViewRowSOTL.Enabled)
                {
                    CheckBox chkSOTLocation = (CheckBox)gridViewRowSOTL.FindControl("chkSOTLocation");
                    chkSOTLocation.Checked = chkSOTicket.Checked;
                    if (!chkSOTLocation.Checked)
                    {
                        DropDownList ddlTechnicianSOTL = (DropDownList)gridViewRowSOTL.FindControl("ddlTechnicianSOTL");
                        //ddlTechnicianSOTL.SelectedValue = Utils.NULL_INT.ToString();
                    }
                }
            }
            TimeSpan duration = DateTime.Now - start;
           // logger.Debug("END chkSOTicket_OnCheckedChanged: " + duration.Minutes + "." + duration.Seconds + "." + duration.Milliseconds);
        }

    }
}
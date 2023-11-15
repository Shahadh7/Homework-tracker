using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace HomeworkTracker
{
    public partial class ProgressTracking : Form
    {

        DateTime dateAndTime;
        int compCount;
        int remaingCount;
        public ProgressTracking()
        {
            InitializeComponent();

            dateAndTime = DateTime.Now;
            var date = dateAndTime.Date;
            todaysDate.Text = date.ToShortDateString();
            todaysDate2.Text = date.ToShortDateString();
        }

        private void getCompletedCount()
        {
            DataAccess db = new DataAccess();
            int count = db.completedTaskCount();
            completedCount.Text = count.ToString();
            compCount = count;
            
        }

        private void getRemainingCount()
        {
            DataAccess db = new DataAccess();
            int count = db.remainingTaskCount();
            RemainingCount.Text = count.ToString();
            remaingCount = count;
        }

        private void ProgressTracking_Load(object sender, EventArgs e)
        {
            getCompletedCount();
            getRemainingCount();
            setGraphValues();
        }

        private void setGraphValues()
        {
            
            float total = remaingCount + compCount;

            float completedPercentage = (compCount / total) * 100;
            float remainingPercentage = (remaingCount / total) * 100;

            parrotPieGraph1.Numbers[0] = (int)completedPercentage;
            parrotPieGraph1.Numbers[1] = (int)remainingPercentage;
        }
    }
}

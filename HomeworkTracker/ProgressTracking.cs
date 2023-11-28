using CustomControlsProject.CustomControls;
using HomeworkTracker.CustomControls;
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
            getAllTasks();
        }

        private void setGraphValues()
        {
            
            float total = remaingCount + compCount;

            float completedPercentage = (compCount / total) * 100;
            float remainingPercentage = (remaingCount / total) * 100;

            parrotPieGraph1.Numbers[0] = (int)completedPercentage;
            parrotPieGraph1.Numbers[1] = (int)remainingPercentage;
            parrotPieGraph1.Invalidate();
        }

        private void getAllTasks()
        {
            DataAccess db = new DataAccess();
            List<Task> tasks = db.GetTasksWithProgress();


            if (tasks.Count > 0)
            {
                flpTasksList.Controls.Clear();
                foreach (Task task in tasks)
                {
                    TaskWithProgress taskWithProgress = new TaskWithProgress();
                    taskWithProgress.Title = task.title;
                    taskWithProgress.DueDate = task.dueDate.ToShortDateString();
                    taskWithProgress.Percentage = task.progressPercentage;
                    taskWithProgress.Data = task;
                    flpTasksList.Controls.Add(taskWithProgress);
                    taskWithProgress.updateParent += OnUpdateParent;
                }
            }
            else
            {
                flpTasksList.Controls.Clear();
                Label label = new Label();
                label.Width = 500;
                label.Text = "No ramaining tasks";
                flpTasksList.Controls.Add(label);
            }

        }

        private void OnUpdateParent(object sender, EventArgs e)
        {
            getCompletedCount();
            getRemainingCount();
            getAllTasks();
            setGraphValues();
        }
    }
}

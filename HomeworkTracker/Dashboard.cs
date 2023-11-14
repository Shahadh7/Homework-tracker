using CustomControlsProject.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkTracker
{
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();
        }

        private void fetchAllPendingTasks()
        {
            DataAccess db = new DataAccess();
            List<Task> tasks = db.GetAllTodaysPendingTasks();

            if (tasks.Count > 0)
            {
                panelPendingTasks.Controls.Clear();
                foreach (Task task in tasks)
                {
                    TaskControl taskControl = new TaskControl();
                    taskControl.Completed = task.completed == 1 ? true : false;
                    taskControl.Title = task.title;
                    taskControl.DueDate = task.dueDate.ToString();
                    taskControl.Percentage = task.progressPercentage;
                    taskControl.ImportanceLevel = task.importanceLevelID.ToString();
                    panelPendingTasks.Controls.Add(taskControl);
                }
            }
            else
            {
                MessageBox.Show("No data available");
            }
        }

        private void fetchAllCompletedTasks()
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            fetchAllPendingTasks();
        }
    }
}

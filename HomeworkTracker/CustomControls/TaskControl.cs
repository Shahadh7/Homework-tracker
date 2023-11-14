using HomeworkTracker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task = HomeworkTracker.Task;

namespace CustomControlsProject.CustomControls
{
    public partial class TaskControl : UserControl
    {

        public event EventHandler TaskCompleted;
        public TaskControl()
        {
            InitializeComponent();
        }


        private string taskTitle;
        private bool completed;
        private dynamic data;
        private string importanceLevel;
        private int percentage;
        private DateTime dueDate;


        [Category("Custom props")]
        public string Title
        {
            get { return taskTitle; }
            set { taskTitle = value; lblTask.Text = value; }
        }

        [Category("Custom props")]
        public string DueDate
        {
            get { return dueDate.ToString(); }
            set { dueDate = DateTime.Parse(value); lblDueDate.Text = value; }
        }

        [Category("Custom props")]
        public bool Completed
        {
            get { return completed; }
            set { completed = value; toggleCompleted.Checked = value; }
        }

        [Category("Custom props")]
        public int Percentage
        {
            get { return percentage; }
            set { percentage = value; progressBar.Value = value; }
        }

        [Category("Custom props")]
        public string ImportanceLevel
        {
            get { return importanceLevel; }
            set
            {

                importanceLevel = value;
                if (importanceLevel == "3")
                {
                    badge1.BGColorA = Color.Yellow;
                    badge1.BGColorB = Color.Yellow;
                    badge1.ForeColor = Color.Yellow;
                }
                else if (importanceLevel == "2")
                {
                    badge1.BGColorA = Color.Green;
                    badge1.BGColorB = Color.Green;
                    badge1.ForeColor = Color.Green;
                }
                else if (importanceLevel == "1")
                {
                    badge1.BGColorA = Color.Red;
                    badge1.BGColorB = Color.Red;
                    badge1.ForeColor = Color.Red;
                }
            }
        }

        public dynamic Data
        {
            get { return data; }
            set { data = value; }
        }

        private void toggleCompleted_MouseClick(object sender, MouseEventArgs e)
        {
            DataAccess db = new DataAccess();
            int completed = data.completed == 1 ? 0 : 1;
            db.toggleCompleted(completed, data.taskID);
            OnTaskCompleted();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EditTaskFormModal editTaskFrom = new();
            editTaskFrom.ShowDialog();
        }

        private void OnTaskCompleted()
        {
            if (TaskCompleted != null)
            {
                TaskCompleted(this, EventArgs.Empty);
            }
        }

    }
}

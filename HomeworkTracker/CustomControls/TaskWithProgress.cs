using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkTracker.CustomControls
{
    public partial class TaskWithProgress : UserControl
    {
        public event EventHandler updateParent;
        public TaskWithProgress()
        {
            InitializeComponent();
        }

        private string taskTitle;
        private int percentage;
        private DateTime dueDate;
        private dynamic data;

        [Category("Custom props")]
        public string Title
        {
            get { return taskTitle; }
            set { taskTitle = value; lblTitle.Text = value; }
        }

        [Category("Custom props")]
        public string DueDate
        {
            get { return dueDate.ToString(); }
            set { dueDate = DateTime.Parse(value); lblDueDate.Text = value; }
        }

        [Category("Custom props")]
        public int Percentage
        {
            get { return percentage; }
            set { percentage = value; progressBar.Value = value; }
        }

        public dynamic Data
        {
            get { return data; }
            set { data = value; }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

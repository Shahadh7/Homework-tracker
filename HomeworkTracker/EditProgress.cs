using ReaLTaiizor.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkTracker
{
    public partial class EditProgress : Form
    {

        Task task;
        public EditProgress(Task task)
        {
            InitializeComponent();
            this.task = task;
            textBoxProgress.Text = task.progressPercentage.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            if (textBoxProgress.Text != string.Empty && int.TryParse(textBoxProgress.Text, out _))
            {
                task.progressPercentage = Convert.ToInt16(textBoxProgress.Text);
            }

            bool isValid = validateData(task);

            if (isValid)
            {
                DataAccess db = new DataAccess();
                db.UpdateTask(task);
                this.Close();
            }
        }

        private bool validateData(Task task)
        {
            bool progressPercentageValid = false;

            if (!int.TryParse(textBoxProgress.Text, out _))
            {
                errorProvider1.SetError(textBoxProgress, "Invalid input.");
            }
            else if (Convert.ToBoolean(task.completed) && task.progressPercentage != 100)
            {
                errorProvider1.SetError(textBoxProgress, "You cannot edit the completed task's progress percentage.");
            }
            else if (task.progressPercentage > 100 || task.progressPercentage < 0)
            {
                errorProvider1.SetError(textBoxProgress, "Progress percentage should be in the range of (0-100).");
            }
            else
            {
                progressPercentageValid = true;
            }

            return progressPercentageValid;
        }
    }
}

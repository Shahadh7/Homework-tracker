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
    public partial class EditTaskFormModal : Form
    {
        Task currenTask;
        List<Category> categories;

        public event EventHandler closeEditModal;

        public EditTaskFormModal(Task task)
        {
            InitializeComponent();
            currenTask = task;
            textBoxTitle.Text = currenTask.title;
            dateTimeDueDate.Text = currenTask.dueDate.ToString();
            fetchDropdownValues();


            textBoxPercentage.Text = currenTask.progressPercentage.ToString();
        }

        private void fetchDropdownValues()
        {
            DataAccess db = new DataAccess();
            categories = db.getAllCategories();
            if (categories != null && categories.Count > 0)
            {
                foreach (Category category in categories)
                {
                    comboBoxCategory.Items.Add(category.name);
                }

                int index = categories.FindIndex(c => c.categoryID.Equals(currenTask.categoryID));

                comboBoxCategory.SelectedIndex = index;
            }

            List<ImportanceLevel> importanceLevels = db.getAllImportanceLevels();
            if (importanceLevels != null && importanceLevels.Count > 0)
            {
                foreach (ImportanceLevel level in importanceLevels)
                {
                    comboBoxPriority.Items.Add(level.name);
                }
                comboBoxPriority.SelectedIndex = currenTask.importanceLevelID - 1;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            editTaskErrorProvider.Clear();
            currenTask.title = textBoxTitle.Text;
            currenTask.dueDate = Convert.ToDateTime(dateTimeDueDate.Text);
            string selectedCategory = comboBoxCategory.Text;

            int index = categories.FindIndex(c => c.name.Equals(selectedCategory));

            currenTask.categoryID = categories[index].categoryID;

            currenTask.importanceLevelID = comboBoxPriority.SelectedIndex + 1;



            if (textBoxPercentage.Text != string.Empty && int.TryParse(textBoxPercentage.Text, out _))
            {
                try
                {
                    currenTask.progressPercentage = Convert.ToInt16(textBoxPercentage.Text);
                }
                catch (Exception) {
                    editTaskErrorProvider.SetError(textBoxPercentage, "Progress percentage should be in the range of (0-100).");
                }
            }

            bool isValid = validateInputs(currenTask);

            if (isValid)
            {
                DataAccess db = new DataAccess();
                db.UpdateTask(currenTask);
                this.Close();
            }
        }

        private bool validateInputs(Task task)
        {
            editTaskErrorProvider.Clear();

            bool titleValid = false;
            bool dueDateValid = false;
            bool importanceLevelValid = false;
            bool categoryValid = false;
            bool progressPercentageValid = false;

            if (task.title == string.Empty)
            {
                editTaskErrorProvider.SetError(textBoxTitle, "Title cannot be empty");
            }
            else
            {
                titleValid = true;
            }

            DateTime todayDate = DateTime.Today;

            if (task.dueDate < todayDate)
            {
                editTaskErrorProvider.SetError(dateTimeDueDate, "Due date is older than today's date.");
            }
            else
            {
                dueDateValid = true;
            }

            if (task.importanceLevelID == 0)
            {
                editTaskErrorProvider.SetError(comboBoxPriority, "Please select a priority.");
            }
            else
            {
                importanceLevelValid = true;
            }

            if (task.categoryID == 0)
            {
                editTaskErrorProvider.SetError(comboBoxCategory, "Please select a a category.");
            }
            else
            {
                categoryValid = true;
            }


            if (!int.TryParse(textBoxPercentage.Text, out _))
            {
                editTaskErrorProvider.SetError(textBoxPercentage, "Invalid input.");
            }
            else if (Convert.ToBoolean(task.completed) && task.progressPercentage != 100)
            {
                editTaskErrorProvider.SetError(textBoxPercentage, "You cannot edit the completed task's progress percentage.");
            }
            else if (task.progressPercentage > 100 || task.progressPercentage < 0)
            {
                editTaskErrorProvider.SetError(textBoxPercentage, "Progress percentage should be in the range of (0-100).");
            }
            else
            {
                progressPercentageValid = true;
            }


            if (titleValid && dueDateValid && importanceLevelValid && categoryValid && progressPercentageValid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

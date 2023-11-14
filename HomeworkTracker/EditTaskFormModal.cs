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
            if (categories != null && categories.Count > 0 )
            {
                foreach (Category category in categories)
                {
                    comboBoxCategory.Items.Add(category.name);
                }

                int index = categories.FindIndex(c => c.categoryID.Equals(currenTask.categoryID));

                comboBoxCategory.SelectedIndex = index;
            }

            List<ImportanceLevel> importanceLevels = db.getAllImportanceLevels();
            if(importanceLevels != null  && importanceLevels.Count > 0 )
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
            currenTask.title = textBoxTitle.Text;
            currenTask.dueDate = Convert.ToDateTime(dateTimeDueDate.Text);
            string selectedCategory = comboBoxCategory.Text;
            
            int index = categories.FindIndex(c => c.name.Equals(selectedCategory));

            currenTask.categoryID = categories[index].categoryID;

            currenTask.importanceLevelID = comboBoxPriority.SelectedIndex + 1;
            currenTask.progressPercentage = Convert.ToInt16(textBoxPercentage.Text);

            if(Convert.ToBoolean(currenTask.completed) && currenTask.progressPercentage != 100)
            {
                MessageBox.Show("You cannot edit the completed task's progress percentage");
                return; 
            }

            DataAccess db = new DataAccess();
            db.UpdateTask(currenTask);
            this.Close();
        }

    }
}

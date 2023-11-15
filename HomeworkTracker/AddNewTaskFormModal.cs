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
    public partial class AddNewTaskFormModal : Form
    {

        List<Category> categories;
        public AddNewTaskFormModal()
        {
            InitializeComponent();
            fetchDropdownValues();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Task task = new Task();
            task.title = textBoxTitle.Text;
            task.dueDate = Convert.ToDateTime(dateTimeDueDate.Text);
            task.importanceLevelID = comboBoxPriority.SelectedIndex + 1;
            task.completed = 0;
            task.progressPercentage = 0;
            task.studentID = globalVariables.currentStudent.studentID;

            var selectedCategory = comboBoxCategory.Text;
            int index = categories.FindIndex(c => c.name.Equals(selectedCategory));

            task.categoryID = categories[index].categoryID;

            if(validateInputs())
            {
                DataAccess db = new DataAccess();
                db.AddTask(task);
                this.Close();
            }
        }

        private bool validateInputs()
        {
            return true;
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
            }

            List<ImportanceLevel> importanceLevels = db.getAllImportanceLevels();
            if (importanceLevels != null && importanceLevels.Count > 0)
            {
                foreach (ImportanceLevel level in importanceLevels)
                {
                    comboBoxPriority.Items.Add(level.name);
                }
            }
        }
    }
}

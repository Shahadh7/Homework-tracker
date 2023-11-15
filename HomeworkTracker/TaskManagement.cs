using CustomControlsProject.CustomControls;
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
    public partial class TaskManagement : Form
    {

        List<Category> categories;
        List<Task> pendingTasks;
        List<Task> completedTasks;

        public TaskManagement()
        {
            InitializeComponent();
        }


        private void fetchAllPendingTasks()
        {
            DataAccess db = new DataAccess();
            pendingTasks = db.GetAllPendingTasks();


            if (pendingTasks.Count > 0)
            {
                panelPendingTasks.Controls.Clear();
                foreach (Task task in pendingTasks)
                {
                    TaskControl taskControl = new TaskControl();
                    taskControl.Completed = task.completed == 1 ? true : false;
                    taskControl.Title = task.title;
                    taskControl.DueDate = task.dueDate.ToString();
                    taskControl.Percentage = task.progressPercentage;
                    taskControl.ImportanceLevel = task.importanceLevelID.ToString();
                    taskControl.Data = task;

                    var foundValue = categories.Find(c => c.categoryID == task.categoryID);
                    taskControl.Category = foundValue.name;

                    panelPendingTasks.Controls.Add(taskControl);
                    taskControl.updateParent += OnUpdateParent;
                }
            }
            else
            {
                panelPendingTasks.Controls.Clear();
                Label label = new Label();
                label.Width = 500;
                label.Text = "No ramaining tasks";
                panelPendingTasks.Controls.Add(label);
            }
        }

        private void fetchAllCompletedTasks()
        {
            DataAccess db = new DataAccess();
            completedTasks = db.GetAllCompletedTasks();

            if (completedTasks.Count > 0)
            {
                panelCompletedTasks.Controls.Clear();
                foreach (Task task in completedTasks)
                {
                    TaskControl taskControl = new TaskControl();
                    taskControl.Completed = task.completed == 1 ? true : false;
                    taskControl.Title = task.title;
                    taskControl.DueDate = task.dueDate.ToString();
                    taskControl.Percentage = task.progressPercentage;
                    taskControl.ImportanceLevel = task.importanceLevelID.ToString();
                    taskControl.Data = task;

                    var foundValue = categories.Find(c => c.categoryID == task.categoryID);
                    taskControl.Category = foundValue.name;
                    panelCompletedTasks.Controls.Add(taskControl);

                    taskControl.updateParent += OnUpdateParent;
                }
            }
            else
            {
                panelCompletedTasks.Controls.Clear();
                Label label = new();
                label.Text = "No data available";
                label.Width = 100;
                panelCompletedTasks.Controls.Add(label);
            }
        }

        private void fetchCategories()
        {
            DataAccess db = new DataAccess();
            categories = db.getAllCategories();

            foreach (Category category in categories)
            {
                comboBoxCategory.Items.Add(category.name);
            }
        }


        private void OnUpdateParent(object sender, EventArgs e)
        {
            fetchAllPendingTasks();
            fetchAllCompletedTasks();
        }

        private void buttonTaskAdd_Click(object sender, EventArgs e)
        {
            AddNewTaskFormModal addNewTaskForm = new AddNewTaskFormModal();
            addNewTaskForm.FormClosed += childForm_FormClosed;
            addNewTaskForm.ShowDialog();
        }

        private void TaskManagement_Load(object sender, EventArgs e)
        {
            fetchCategories();
            fetchAllPendingTasks();
            fetchAllCompletedTasks();
        }

        private void filterData(int categoryID)
        {
            List<Task> filteredtasks = pendingTasks
                .Where(item => item.categoryID == categoryID)
                .ToList();

            panelPendingTasks.Controls.Clear();
            if(filteredtasks.Count > 0)
            {
                foreach (Task task in filteredtasks)
                {
                    TaskControl taskControl = new TaskControl();
                    taskControl.Completed = task.completed == 1 ? true : false;
                    taskControl.Title = task.title;
                    taskControl.DueDate = task.dueDate.ToString();
                    taskControl.Percentage = task.progressPercentage;
                    taskControl.ImportanceLevel = task.importanceLevelID.ToString();
                    taskControl.Data = task;

                    var foundValue = categories.Find(c => c.categoryID == task.categoryID);
                    taskControl.Category = foundValue.name;
                    panelPendingTasks.Controls.Add(taskControl);

                    taskControl.updateParent += OnUpdateParent;
                }
            }
            else
            {
                Label label = new Label();
                label.Width = 500;
                label.Text = "No results match the specified criteria";
                panelPendingTasks.Controls.Add(label);
            }
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBoxCategory.SelectedItem.ToString();

            var findCatID = categories.Find(c => c.name == selectedValue).categoryID;

            filterData(findCatID);
        }

        private void buttonResetFilter_Click(object sender, EventArgs e)
        {
            fetchAllPendingTasks();
        }

        private void searchIcon_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Length > 0)
            {
                List<Task> filteredtasks = pendingTasks
                .Where(item => item.title.ToLower().Contains(textBoxSearch.Text.Trim().ToLower()))
                .ToList();

                panelPendingTasks.Controls.Clear();
                if(filteredtasks.Count > 0)
                {
                    foreach (Task task in filteredtasks)
                    {
                        TaskControl taskControl = new TaskControl();
                        taskControl.Completed = task.completed == 1 ? true : false;
                        taskControl.Title = task.title;
                        taskControl.DueDate = task.dueDate.ToString();
                        taskControl.Percentage = task.progressPercentage;
                        taskControl.ImportanceLevel = task.importanceLevelID.ToString();
                        taskControl.Data = task;

                        var foundValue = categories.Find(c => c.categoryID == task.categoryID);
                        taskControl.Category = foundValue.name;
                        panelPendingTasks.Controls.Add(taskControl);

                        taskControl.updateParent += OnUpdateParent;
                    }
                }
                else
                {
                    Label label = new Label();
                    label.Width = 500;
                    label.Text = "There are no matching records based on your search term";
                    panelPendingTasks.Controls.Add(label);
                }
            }
            else
            {
                fetchAllPendingTasks();
            }
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxSearch.Text.Length == 0)
            {
                fetchAllPendingTasks();
            }
        }

        private void childForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            fetchAllPendingTasks();
        }
    }
}

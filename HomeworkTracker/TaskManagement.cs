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
        public TaskManagement()
        {
            InitializeComponent();

            task1.Title = "Hello world";
            task1.ImportanceLevel = "Medium";
            task1.Percentage = 10;
            task2.Percentage = 30;
            task3.Percentage = 70;
            task4.Completed = true;
            task5.Completed = true;
            task6.Completed = true;
            task4.Percentage = 100;
            task5.Percentage = 100;
            task6.Percentage = 100;
        }

        private void buttonTaskAdd_Click(object sender, EventArgs e)
        {
            AddNewTaskFormModal addNewTaskForm = new AddNewTaskFormModal();
            addNewTaskForm.ShowDialog();
        }
    }
}

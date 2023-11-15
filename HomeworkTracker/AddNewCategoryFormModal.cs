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
    public partial class AddNewCategoryFormModal : Form
    {
        public AddNewCategoryFormModal()
        {
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string categoryName =  textBoxCategory.Text;

            if(categoryName != string.Empty) { 
                Category category = new Category();
                category.name = categoryName;
                category.studentID = globalVariables.currentStudent.studentID;
                DataAccess db = new DataAccess();
                db.AddCategory(category);
                this.Close();
            }
            else
            {
                MessageBox.Show("Category name cannot be empty.");
            }
        }
    }
}

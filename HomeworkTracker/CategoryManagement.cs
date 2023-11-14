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
    public partial class CategoryManagement : Form
    {
        public CategoryManagement()
        {
            InitializeComponent();
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            AddNewCategoryFormModal addNewCategory = new();
            addNewCategory.ShowDialog();
        }

        private void buttonEditCategory_Click(object sender, EventArgs e)
        {
            EditCategoryFormModal editCategory = new();
            editCategory.ShowDialog();
        }
    }
}

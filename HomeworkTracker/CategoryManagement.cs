using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkTracker
{
    public partial class CategoryManagement : Form
    {

        List<Category> categories;

        int currentlySelectedIndex = -1;

        public CategoryManagement()
        {
            InitializeComponent();
            fetchAllAvailableCategories();
            this.dgvCategoryTable.AllowUserToAddRows = false;
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            AddNewCategoryFormModal addNewCategory = new();
            addNewCategory.FormClosed += childForm_FormClosed;
            addNewCategory.ShowDialog();
        }

        private void childForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            fetchAllAvailableCategories();
        }

        private void fetchAllAvailableCategories()
        {
            dgvCategoryTable.Rows.Clear();
            DataAccess db = new DataAccess();
            categories = db.getAllCategories();

            if (categories != null)
            {
                int count = 0;

                foreach (Category category in categories)
                {
                    dgvCategoryTable.Rows.Add(count + 1, category.name);
                    count++;
                }
            }
        }

        private void dgvCategoryTable_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Category seletedCategory = categories[e.RowIndex];
            EditCategoryFormModal editCategory = new(seletedCategory);
            editCategory.FormClosed += childForm_FormClosed;
            editCategory.ShowDialog();
        }



        private void dgvCategoryTable_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            currentlySelectedIndex = e.RowIndex;
        }

        private void buttonDeleteCategory_Click(object sender, EventArgs e)
        {
            
            if (currentlySelectedIndex != -1)
            {
                int categoryID = categories[currentlySelectedIndex].categoryID;
                DataAccess db = new DataAccess();
                bool isExist = db.isTaskExistsWithCategoryID(categoryID);

                if (!isExist)
                {
                    db.RemoveCategory(categoryID);
                    fetchAllAvailableCategories();
                }
                else
                {
                    MessageBox.Show("Unable to delete category: Tasks are still associated with this category. Please remove all tasks from this category before attempting to delete it.");
                }

            }
            else
            {
                MessageBox.Show("Please select a row to delete");
            }
            currentlySelectedIndex = -1;
        }
    }
}

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
            Category seletedCategory = new Category();

            if (dgvCategoryTable.SelectedRows.Count != 0)
            {
                DataGridViewRow row = dgvCategoryTable.SelectedRows[0];
                string catName = (string)row.Cells["Category"].Value;
                seletedCategory = categories.Find(item => item.name == catName);

            }
            EditCategoryFormModal editCategory = new(seletedCategory);
            editCategory.FormClosed += childForm_FormClosed;
            editCategory.ShowDialog();
        }

        private void buttonDeleteCategory_Click(object sender, EventArgs e)
        {

            if (dgvCategoryTable.SelectedRows.Count != 0)
            {
                DataGridViewRow row = dgvCategoryTable.SelectedRows[0];
                string catName = (string)row.Cells["Category"].Value;
                var category = categories.Find(item => item.name == catName);

                if (category != null)
                {
                    DataAccess db = new DataAccess();
                    bool isExist = db.isTaskExistsWithCategoryID(category.categoryID);

                    if (!isExist)
                    {
                        db.RemoveCategory(category.categoryID);
                        fetchAllAvailableCategories();
                    }
                    else
                    {
                        MessageBox.Show("Unable to delete category: Tasks are still associated with this category. Please remove all tasks from this category before attempting to delete it.");
                    }
                }
                

            }
            else
            {
                MessageBox.Show("Please select a row to delete");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

            string searchTerm = textBoxSearch.Text;
            if (searchTerm != string.Empty)
            {
                
                List<Category> result = categories.FindAll(item => item.name.ToLower().Contains(searchTerm.ToLower()));
                if (categories != null)
                {
                    int count = 0;
                    dgvCategoryTable.Rows.Clear();
                    foreach (Category category in result)
                    {
                        dgvCategoryTable.Rows.Add(count + 1, category.name);
                        count++;
                    }
                }

            }
            else
            {
                MessageBox.Show("Search text is empty.");
            }
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(textBoxSearch.Text.Length == 0)
            {
                fetchAllAvailableCategories();
            }
        }
    }
}

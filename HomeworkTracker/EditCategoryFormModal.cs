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
    public partial class EditCategoryFormModal : Form
    {

        Category category;
        public EditCategoryFormModal(Category category)
        {
            InitializeComponent();
            this.category = category;
            textBoxTitle.Text = this.category.name;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if(textBoxTitle.Text != string.Empty)
            {
                category.name = textBoxTitle.Text;
                DataAccess db = new DataAccess();
                db.UpdateCategory(category);
                this.Close();
            }
            else
            {
                MessageBox.Show("Category name cannot be empty.");
            }
        }
    }
}

namespace HomeworkTracker
{
    partial class CategoryManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelHeading = new Label();
            dgvCategoryTable = new DataGridView();
            count = new DataGridViewTextBoxColumn();
            category = new DataGridViewTextBoxColumn();
            textBoxSearch = new CustomControls.RJControls.CustomTextBox();
            buttonAddCategory = new CustomControls.RJControls.CustomButton();
            buttonDeleteCategory = new CustomControls.RJControls.CustomButton();
            buttonSearch = new CustomControls.RJControls.CustomButton();
            ((System.ComponentModel.ISupportInitialize)dgvCategoryTable).BeginInit();
            SuspendLayout();
            // 
            // labelHeading
            // 
            labelHeading.AutoSize = true;
            labelHeading.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelHeading.Location = new Point(230, 9);
            labelHeading.Name = "labelHeading";
            labelHeading.Size = new Size(318, 40);
            labelHeading.TabIndex = 6;
            labelHeading.Text = "Category Management";
            // 
            // dgvCategoryTable
            // 
            dgvCategoryTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoryTable.Columns.AddRange(new DataGridViewColumn[] { count, category });
            dgvCategoryTable.Location = new Point(59, 140);
            dgvCategoryTable.Name = "dgvCategoryTable";
            dgvCategoryTable.RowTemplate.Height = 25;
            dgvCategoryTable.Size = new Size(643, 524);
            dgvCategoryTable.TabIndex = 7;
            dgvCategoryTable.RowHeaderMouseDoubleClick += dgvCategoryTable_RowHeaderMouseDoubleClick;
            // 
            // count
            // 
            count.HeaderText = "#";
            count.Name = "count";
            count.ReadOnly = true;
            count.Width = 300;
            // 
            // category
            // 
            category.HeaderText = "Category";
            category.Name = "category";
            category.ReadOnly = true;
            category.Width = 300;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BackColor = SystemColors.Window;
            textBoxSearch.BorderColor = Color.Transparent;
            textBoxSearch.BorderFocusColor = Color.CornflowerBlue;
            textBoxSearch.BorderRadius = 0;
            textBoxSearch.BorderSize = 2;
            textBoxSearch.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.ForeColor = Color.FromArgb(64, 64, 64);
            textBoxSearch.Location = new Point(59, 93);
            textBoxSearch.Margin = new Padding(4);
            textBoxSearch.Multiline = false;
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Padding = new Padding(10, 7, 10, 7);
            textBoxSearch.PasswordChar = false;
            textBoxSearch.PlaceholderColor = Color.DarkGray;
            textBoxSearch.PlaceholderText = "Search category";
            textBoxSearch.Size = new Size(250, 31);
            textBoxSearch.TabIndex = 8;
            textBoxSearch.UnderlinedStyle = false;
            textBoxSearch.KeyPress += textBoxSearch_KeyPress;
            // 
            // buttonAddCategory
            // 
            buttonAddCategory.BackColor = Color.FromArgb(239, 69, 101);
            buttonAddCategory.BackgroundColor = Color.FromArgb(239, 69, 101);
            buttonAddCategory.BorderColor = Color.PaleVioletRed;
            buttonAddCategory.BorderRadius = 5;
            buttonAddCategory.BorderSize = 0;
            buttonAddCategory.FlatAppearance.BorderSize = 0;
            buttonAddCategory.FlatStyle = FlatStyle.Flat;
            buttonAddCategory.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddCategory.ForeColor = Color.White;
            buttonAddCategory.Location = new Point(538, 93);
            buttonAddCategory.Name = "buttonAddCategory";
            buttonAddCategory.Size = new Size(79, 31);
            buttonAddCategory.TabIndex = 9;
            buttonAddCategory.Text = "Add New";
            buttonAddCategory.TextColor = Color.White;
            buttonAddCategory.UseVisualStyleBackColor = false;
            buttonAddCategory.Click += buttonAddCategory_Click;
            // 
            // buttonDeleteCategory
            // 
            buttonDeleteCategory.BackColor = Color.FromArgb(239, 69, 101);
            buttonDeleteCategory.BackgroundColor = Color.FromArgb(239, 69, 101);
            buttonDeleteCategory.BorderColor = Color.PaleVioletRed;
            buttonDeleteCategory.BorderRadius = 5;
            buttonDeleteCategory.BorderSize = 0;
            buttonDeleteCategory.FlatAppearance.BorderSize = 0;
            buttonDeleteCategory.FlatStyle = FlatStyle.Flat;
            buttonDeleteCategory.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDeleteCategory.ForeColor = Color.White;
            buttonDeleteCategory.Location = new Point(623, 93);
            buttonDeleteCategory.Name = "buttonDeleteCategory";
            buttonDeleteCategory.Size = new Size(79, 31);
            buttonDeleteCategory.TabIndex = 11;
            buttonDeleteCategory.Text = "Delete";
            buttonDeleteCategory.TextColor = Color.White;
            buttonDeleteCategory.UseVisualStyleBackColor = false;
            buttonDeleteCategory.Click += buttonDeleteCategory_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.FromArgb(239, 69, 101);
            buttonSearch.BackgroundColor = Color.FromArgb(239, 69, 101);
            buttonSearch.BorderColor = Color.PaleVioletRed;
            buttonSearch.BorderRadius = 5;
            buttonSearch.BorderSize = 0;
            buttonSearch.FlatAppearance.BorderSize = 0;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSearch.ForeColor = Color.White;
            buttonSearch.Location = new Point(328, 93);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(79, 31);
            buttonSearch.TabIndex = 12;
            buttonSearch.Text = "Search";
            buttonSearch.TextColor = Color.White;
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // CategoryManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 238, 254);
            ClientSize = new Size(760, 783);
            ControlBox = false;
            Controls.Add(buttonSearch);
            Controls.Add(buttonDeleteCategory);
            Controls.Add(buttonAddCategory);
            Controls.Add(textBoxSearch);
            Controls.Add(dgvCategoryTable);
            Controls.Add(labelHeading);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CategoryManagement";
            Text = "CategoryManagement";
            ((System.ComponentModel.ISupportInitialize)dgvCategoryTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHeading;
        private DataGridView dgvCategoryTable;
        private DataGridViewTextBoxColumn count;
        private DataGridViewTextBoxColumn category;
        private CustomControls.RJControls.CustomTextBox textBoxSearch;
        private CustomControls.RJControls.CustomButton buttonAddCategory;
        private CustomControls.RJControls.CustomButton buttonDeleteCategory;
        private CustomControls.RJControls.CustomButton buttonSearch;
    }
}
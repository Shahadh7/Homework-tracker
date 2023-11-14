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
            dataGridView1 = new DataGridView();
            count = new DataGridViewTextBoxColumn();
            category = new DataGridViewTextBoxColumn();
            customTextBox1 = new CustomControls.RJControls.CustomTextBox();
            buttonAddCategory = new CustomControls.RJControls.CustomButton();
            buttonEditCategory = new CustomControls.RJControls.CustomButton();
            buttonDeleteCategory = new CustomControls.RJControls.CustomButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { count, category });
            dataGridView1.Location = new Point(59, 140);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(643, 524);
            dataGridView1.TabIndex = 7;
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
            // customTextBox1
            // 
            customTextBox1.BackColor = SystemColors.Window;
            customTextBox1.BorderColor = Color.Transparent;
            customTextBox1.BorderFocusColor = Color.CornflowerBlue;
            customTextBox1.BorderRadius = 0;
            customTextBox1.BorderSize = 2;
            customTextBox1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            customTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            customTextBox1.Location = new Point(59, 93);
            customTextBox1.Margin = new Padding(4);
            customTextBox1.Multiline = false;
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Padding = new Padding(10, 7, 10, 7);
            customTextBox1.PasswordChar = false;
            customTextBox1.PlaceholderColor = Color.DarkGray;
            customTextBox1.PlaceholderText = "Search category";
            customTextBox1.Size = new Size(250, 31);
            customTextBox1.TabIndex = 8;
            customTextBox1.UnderlinedStyle = false;
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
            buttonAddCategory.Location = new Point(453, 93);
            buttonAddCategory.Name = "buttonAddCategory";
            buttonAddCategory.Size = new Size(79, 31);
            buttonAddCategory.TabIndex = 9;
            buttonAddCategory.Text = "Add New";
            buttonAddCategory.TextColor = Color.White;
            buttonAddCategory.UseVisualStyleBackColor = false;
            buttonAddCategory.Click += buttonAddCategory_Click;
            // 
            // buttonEditCategory
            // 
            buttonEditCategory.BackColor = Color.FromArgb(239, 69, 101);
            buttonEditCategory.BackgroundColor = Color.FromArgb(239, 69, 101);
            buttonEditCategory.BorderColor = Color.PaleVioletRed;
            buttonEditCategory.BorderRadius = 5;
            buttonEditCategory.BorderSize = 0;
            buttonEditCategory.FlatAppearance.BorderSize = 0;
            buttonEditCategory.FlatStyle = FlatStyle.Flat;
            buttonEditCategory.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEditCategory.ForeColor = Color.White;
            buttonEditCategory.Location = new Point(538, 93);
            buttonEditCategory.Name = "buttonEditCategory";
            buttonEditCategory.Size = new Size(79, 31);
            buttonEditCategory.TabIndex = 10;
            buttonEditCategory.Text = "Edit";
            buttonEditCategory.TextColor = Color.White;
            buttonEditCategory.UseVisualStyleBackColor = false;
            buttonEditCategory.Click += buttonEditCategory_Click;
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
            // 
            // CategoryManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 238, 254);
            ClientSize = new Size(760, 783);
            ControlBox = false;
            Controls.Add(buttonDeleteCategory);
            Controls.Add(buttonEditCategory);
            Controls.Add(buttonAddCategory);
            Controls.Add(customTextBox1);
            Controls.Add(dataGridView1);
            Controls.Add(labelHeading);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CategoryManagement";
            Text = "CategoryManagement";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHeading;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn count;
        private DataGridViewTextBoxColumn category;
        private CustomControls.RJControls.CustomTextBox customTextBox1;
        private CustomControls.RJControls.CustomButton buttonAddCategory;
        private CustomControls.RJControls.CustomButton buttonEditCategory;
        private CustomControls.RJControls.CustomButton buttonDeleteCategory;
    }
}
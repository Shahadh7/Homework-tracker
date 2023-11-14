namespace HomeworkTracker
{
    partial class TaskManagement
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
            panelPendingTasks = new FlowLayoutPanel();
            textBoxSearch = new CustomControls.RJControls.CustomTextBox();
            buttonTaskAdd = new CustomControls.RJControls.CustomButton();
            labelHeading = new Label();
            comboBoxCategory = new ReaLTaiizor.Controls.PoisonComboBox();
            label1 = new Label();
            panelCompletedTasks = new FlowLayoutPanel();
            labelRemaining = new ReaLTaiizor.Controls.FoxLabel();
            labelCompleted = new ReaLTaiizor.Controls.FoxLabel();
            buttonResetFilter = new CustomControls.RJControls.CustomButton();
            searchIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)searchIcon).BeginInit();
            SuspendLayout();
            // 
            // panelPendingTasks
            // 
            panelPendingTasks.AutoScroll = true;
            panelPendingTasks.Location = new Point(34, 159);
            panelPendingTasks.Name = "panelPendingTasks";
            panelPendingTasks.Size = new Size(697, 289);
            panelPendingTasks.TabIndex = 1;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BackColor = SystemColors.Window;
            textBoxSearch.BorderColor = Color.Transparent;
            textBoxSearch.BorderFocusColor = Color.CornflowerBlue;
            textBoxSearch.BorderRadius = 5;
            textBoxSearch.BorderSize = 2;
            textBoxSearch.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.ForeColor = Color.FromArgb(64, 64, 64);
            textBoxSearch.Location = new Point(34, 83);
            textBoxSearch.Margin = new Padding(4);
            textBoxSearch.Multiline = false;
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Padding = new Padding(10, 7, 10, 7);
            textBoxSearch.PasswordChar = false;
            textBoxSearch.PlaceholderColor = Color.DarkGray;
            textBoxSearch.PlaceholderText = "Search";
            textBoxSearch.Size = new Size(145, 31);
            textBoxSearch.TabIndex = 2;
            textBoxSearch.UnderlinedStyle = false;
            textBoxSearch.KeyPress += textBoxSearch_KeyPress;
            // 
            // buttonTaskAdd
            // 
            buttonTaskAdd.BackColor = Color.FromArgb(239, 69, 101);
            buttonTaskAdd.BackgroundColor = Color.FromArgb(239, 69, 101);
            buttonTaskAdd.BorderColor = Color.PaleVioletRed;
            buttonTaskAdd.BorderRadius = 5;
            buttonTaskAdd.BorderSize = 0;
            buttonTaskAdd.FlatAppearance.BorderSize = 0;
            buttonTaskAdd.FlatStyle = FlatStyle.Flat;
            buttonTaskAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTaskAdd.ForeColor = Color.White;
            buttonTaskAdd.Location = new Point(596, 83);
            buttonTaskAdd.Name = "buttonTaskAdd";
            buttonTaskAdd.Size = new Size(135, 31);
            buttonTaskAdd.TabIndex = 3;
            buttonTaskAdd.Text = "Add New";
            buttonTaskAdd.TextColor = Color.White;
            buttonTaskAdd.UseVisualStyleBackColor = false;
            buttonTaskAdd.Click += buttonTaskAdd_Click;
            // 
            // labelHeading
            // 
            labelHeading.AutoSize = true;
            labelHeading.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelHeading.Location = new Point(258, 9);
            labelHeading.Name = "labelHeading";
            labelHeading.Size = new Size(255, 40);
            labelHeading.TabIndex = 5;
            labelHeading.Text = "Task Management";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.ItemHeight = 23;
            comboBoxCategory.Location = new Point(303, 85);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.PromptText = "Filter by Category";
            comboBoxCategory.Size = new Size(170, 29);
            comboBoxCategory.TabIndex = 6;
            comboBoxCategory.Text = "Filter by Category";
            comboBoxCategory.UseSelectable = true;
            comboBoxCategory.SelectedIndexChanged += comboBoxCategory_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(255, 90);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 7;
            label1.Text = "Filter";
            // 
            // panelCompletedTasks
            // 
            panelCompletedTasks.AutoScroll = true;
            panelCompletedTasks.Location = new Point(34, 482);
            panelCompletedTasks.Name = "panelCompletedTasks";
            panelCompletedTasks.Size = new Size(697, 289);
            panelCompletedTasks.TabIndex = 8;
            // 
            // labelRemaining
            // 
            labelRemaining.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelRemaining.ForeColor = Color.FromArgb(76, 88, 100);
            labelRemaining.Location = new Point(37, 134);
            labelRemaining.Name = "labelRemaining";
            labelRemaining.Size = new Size(116, 19);
            labelRemaining.TabIndex = 9;
            labelRemaining.Text = "Remaining Tasks";
            // 
            // labelCompleted
            // 
            labelCompleted.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelCompleted.ForeColor = Color.FromArgb(76, 88, 100);
            labelCompleted.Location = new Point(37, 460);
            labelCompleted.Name = "labelCompleted";
            labelCompleted.Size = new Size(116, 19);
            labelCompleted.TabIndex = 10;
            labelCompleted.Text = "Completed Tasks";
            // 
            // buttonResetFilter
            // 
            buttonResetFilter.BackColor = Color.FromArgb(239, 69, 101);
            buttonResetFilter.BackgroundColor = Color.FromArgb(239, 69, 101);
            buttonResetFilter.BorderColor = Color.PaleVioletRed;
            buttonResetFilter.BorderRadius = 5;
            buttonResetFilter.BorderSize = 0;
            buttonResetFilter.FlatAppearance.BorderSize = 0;
            buttonResetFilter.FlatStyle = FlatStyle.Flat;
            buttonResetFilter.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonResetFilter.ForeColor = Color.White;
            buttonResetFilter.Location = new Point(479, 85);
            buttonResetFilter.Name = "buttonResetFilter";
            buttonResetFilter.Size = new Size(108, 31);
            buttonResetFilter.TabIndex = 11;
            buttonResetFilter.Text = "Reset filter";
            buttonResetFilter.TextColor = Color.White;
            buttonResetFilter.UseVisualStyleBackColor = false;
            buttonResetFilter.Click += buttonResetFilter_Click;
            // 
            // searchIcon
            // 
            searchIcon.Image = Properties.Resources.Search;
            searchIcon.Location = new Point(184, 85);
            searchIcon.Name = "searchIcon";
            searchIcon.Size = new Size(31, 29);
            searchIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            searchIcon.TabIndex = 12;
            searchIcon.TabStop = false;
            searchIcon.Click += searchIcon_Click;
            // 
            // TaskManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 238, 254);
            ClientSize = new Size(760, 783);
            ControlBox = false;
            Controls.Add(searchIcon);
            Controls.Add(buttonResetFilter);
            Controls.Add(labelCompleted);
            Controls.Add(labelRemaining);
            Controls.Add(panelCompletedTasks);
            Controls.Add(label1);
            Controls.Add(comboBoxCategory);
            Controls.Add(labelHeading);
            Controls.Add(buttonTaskAdd);
            Controls.Add(textBoxSearch);
            Controls.Add(panelPendingTasks);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TaskManagement";
            Text = "TaskManagement";
            Load += TaskManagement_Load;
            ((System.ComponentModel.ISupportInitialize)searchIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel panelPendingTasks;
        private CustomControls.RJControls.CustomTextBox textBoxSearch;
        private CustomControls.RJControls.CustomButton buttonTaskAdd;
        private Label labelHeading;
        private ReaLTaiizor.Controls.PoisonComboBox comboBoxCategory;
        private Label label1;
        private FlowLayoutPanel panelCompletedTasks;
        private ReaLTaiizor.Controls.FoxLabel labelRemaining;
        private ReaLTaiizor.Controls.FoxLabel labelCompleted;
        private CustomControls.RJControls.CustomButton buttonResetFilter;
        private PictureBox searchIcon;
    }
}
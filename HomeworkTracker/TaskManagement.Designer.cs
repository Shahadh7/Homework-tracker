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
            flowLayoutPanel1 = new FlowLayoutPanel();
            task1 = new CustomControlsProject.CustomControls.task();
            task2 = new CustomControlsProject.CustomControls.task();
            task3 = new CustomControlsProject.CustomControls.task();
            customTextBox1 = new CustomControls.RJControls.CustomTextBox();
            buttonTaskAdd = new CustomControls.RJControls.CustomButton();
            labelHeading = new Label();
            poisonComboBox1 = new ReaLTaiizor.Controls.PoisonComboBox();
            label1 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            task4 = new CustomControlsProject.CustomControls.task();
            task5 = new CustomControlsProject.CustomControls.task();
            task6 = new CustomControlsProject.CustomControls.task();
            labelRemaining = new ReaLTaiizor.Controls.FoxLabel();
            labelCompleted = new ReaLTaiizor.Controls.FoxLabel();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(task1);
            flowLayoutPanel1.Controls.Add(task2);
            flowLayoutPanel1.Controls.Add(task3);
            flowLayoutPanel1.Location = new Point(34, 159);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(697, 289);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // task1
            // 
            task1.BackColor = Color.White;
            task1.Completed = false;
            task1.Data = null;
            task1.ImportanceLevel = null;
            task1.Location = new Point(3, 3);
            task1.Name = "task1";
            task1.Percentage = 0;
            task1.Size = new Size(690, 68);
            task1.TabIndex = 0;
            task1.Title = null;
            // 
            // task2
            // 
            task2.BackColor = Color.White;
            task2.Completed = false;
            task2.Data = null;
            task2.ImportanceLevel = null;
            task2.Location = new Point(3, 77);
            task2.Name = "task2";
            task2.Percentage = 0;
            task2.Size = new Size(690, 68);
            task2.TabIndex = 1;
            task2.Title = null;
            // 
            // task3
            // 
            task3.BackColor = Color.White;
            task3.Completed = false;
            task3.Data = null;
            task3.ImportanceLevel = null;
            task3.Location = new Point(3, 151);
            task3.Name = "task3";
            task3.Percentage = 0;
            task3.Size = new Size(690, 68);
            task3.TabIndex = 2;
            task3.Title = null;
            // 
            // customTextBox1
            // 
            customTextBox1.BackColor = SystemColors.Window;
            customTextBox1.BorderColor = Color.Transparent;
            customTextBox1.BorderFocusColor = Color.CornflowerBlue;
            customTextBox1.BorderRadius = 5;
            customTextBox1.BorderSize = 2;
            customTextBox1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            customTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            customTextBox1.Location = new Point(34, 83);
            customTextBox1.Margin = new Padding(4);
            customTextBox1.Multiline = false;
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Padding = new Padding(10, 7, 10, 7);
            customTextBox1.PasswordChar = false;
            customTextBox1.PlaceholderColor = Color.DarkGray;
            customTextBox1.PlaceholderText = "Search";
            customTextBox1.Size = new Size(227, 31);
            customTextBox1.TabIndex = 2;
            customTextBox1.UnderlinedStyle = false;
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
            buttonTaskAdd.Location = new Point(581, 83);
            buttonTaskAdd.Name = "buttonTaskAdd";
            buttonTaskAdd.Size = new Size(150, 31);
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
            // poisonComboBox1
            // 
            poisonComboBox1.FormattingEnabled = true;
            poisonComboBox1.ItemHeight = 23;
            poisonComboBox1.Location = new Point(405, 85);
            poisonComboBox1.Name = "poisonComboBox1";
            poisonComboBox1.PromptText = "Filter by Category";
            poisonComboBox1.Size = new Size(170, 29);
            poisonComboBox1.TabIndex = 6;
            poisonComboBox1.Text = "Filter by Category";
            poisonComboBox1.UseSelectable = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(357, 90);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 7;
            label1.Text = "Filter";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.Controls.Add(task4);
            flowLayoutPanel2.Controls.Add(task5);
            flowLayoutPanel2.Controls.Add(task6);
            flowLayoutPanel2.Location = new Point(34, 482);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(697, 289);
            flowLayoutPanel2.TabIndex = 8;
            // 
            // task4
            // 
            task4.BackColor = Color.White;
            task4.Completed = false;
            task4.Data = null;
            task4.ImportanceLevel = null;
            task4.Location = new Point(3, 3);
            task4.Name = "task4";
            task4.Percentage = 0;
            task4.Size = new Size(690, 68);
            task4.TabIndex = 0;
            task4.Title = null;
            // 
            // task5
            // 
            task5.BackColor = Color.White;
            task5.Completed = false;
            task5.Data = null;
            task5.ImportanceLevel = null;
            task5.Location = new Point(3, 77);
            task5.Name = "task5";
            task5.Percentage = 0;
            task5.Size = new Size(690, 68);
            task5.TabIndex = 1;
            task5.Title = null;
            // 
            // task6
            // 
            task6.BackColor = Color.White;
            task6.Completed = false;
            task6.Data = null;
            task6.ImportanceLevel = null;
            task6.Location = new Point(3, 151);
            task6.Name = "task6";
            task6.Percentage = 0;
            task6.Size = new Size(690, 68);
            task6.TabIndex = 2;
            task6.Title = null;
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
            // TaskManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 238, 254);
            ClientSize = new Size(760, 783);
            ControlBox = false;
            Controls.Add(labelCompleted);
            Controls.Add(labelRemaining);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(label1);
            Controls.Add(poisonComboBox1);
            Controls.Add(labelHeading);
            Controls.Add(buttonTaskAdd);
            Controls.Add(customTextBox1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TaskManagement";
            Text = "TaskManagement";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private CustomControls.RJControls.CustomTextBox customTextBox1;
        private CustomControls.RJControls.CustomButton buttonTaskAdd;
        private CustomControlsProject.CustomControls.task task1;
        private CustomControlsProject.CustomControls.task task2;
        private CustomControlsProject.CustomControls.task task3;
        private Label labelHeading;
        private ReaLTaiizor.Controls.PoisonComboBox poisonComboBox1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel2;
        private CustomControlsProject.CustomControls.task task4;
        private CustomControlsProject.CustomControls.task task5;
        private CustomControlsProject.CustomControls.task task6;
        private ReaLTaiizor.Controls.FoxLabel labelRemaining;
        private ReaLTaiizor.Controls.FoxLabel labelCompleted;
    }
}
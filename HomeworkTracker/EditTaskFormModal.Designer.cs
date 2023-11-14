namespace HomeworkTracker
{
    partial class EditTaskFormModal
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
            closeButton = new ReaLTaiizor.Controls.SpaceClose();
            buttonReset = new CustomControls.RJControls.CustomButton();
            buttonUpdate = new CustomControls.RJControls.CustomButton();
            comboBoxPriority = new ReaLTaiizor.Controls.PoisonComboBox();
            comboBoxCategory = new ReaLTaiizor.Controls.PoisonComboBox();
            dateTimeDueDate = new ReaLTaiizor.Controls.PoisonDateTime();
            textBoxTitle = new CustomControls.RJControls.CustomTextBox();
            labelPriority = new Label();
            labelCategory = new Label();
            labelDueDate = new Label();
            labelTitle = new Label();
            labelHeading = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeButton.Customization = "DQ/S/xhh8/8yMjL/Kioq/x5/9/8ND9L//v7+/yMjI/8qKir/";
            closeButton.DefaultAnchor = true;
            closeButton.DefaultLocation = true;
            closeButton.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            closeButton.Image = null;
            closeButton.Location = new Point(620, 3);
            closeButton.Margin = new Padding(3, 20, 3, 3);
            closeButton.Name = "closeButton";
            closeButton.NoRounding = false;
            closeButton.Size = new Size(38, 35);
            closeButton.TabIndex = 14;
            closeButton.Text = "x";
            closeButton.Transparent = false;
            // 
            // buttonReset
            // 
            buttonReset.BackColor = Color.Gray;
            buttonReset.BackgroundColor = Color.Gray;
            buttonReset.BorderColor = Color.PaleVioletRed;
            buttonReset.BorderRadius = 5;
            buttonReset.BorderSize = 0;
            buttonReset.FlatAppearance.BorderSize = 0;
            buttonReset.FlatStyle = FlatStyle.Flat;
            buttonReset.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReset.ForeColor = Color.White;
            buttonReset.Location = new Point(292, 384);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(150, 40);
            buttonReset.TabIndex = 13;
            buttonReset.Text = "Reset";
            buttonReset.TextColor = Color.White;
            buttonReset.UseVisualStyleBackColor = false;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.LimeGreen;
            buttonUpdate.BackgroundColor = Color.LimeGreen;
            buttonUpdate.BorderColor = Color.PaleVioletRed;
            buttonUpdate.BorderRadius = 5;
            buttonUpdate.BorderSize = 0;
            buttonUpdate.FlatAppearance.BorderSize = 0;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUpdate.ForeColor = Color.White;
            buttonUpdate.Location = new Point(472, 384);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(150, 40);
            buttonUpdate.TabIndex = 12;
            buttonUpdate.Text = "Save";
            buttonUpdate.TextColor = Color.White;
            buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // comboBoxPriority
            // 
            comboBoxPriority.FormattingEnabled = true;
            comboBoxPriority.ItemHeight = 23;
            comboBoxPriority.Location = new Point(180, 315);
            comboBoxPriority.Name = "comboBoxPriority";
            comboBoxPriority.Size = new Size(442, 29);
            comboBoxPriority.TabIndex = 11;
            comboBoxPriority.UseSelectable = true;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.ItemHeight = 23;
            comboBoxCategory.Location = new Point(180, 261);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(442, 29);
            comboBoxCategory.TabIndex = 10;
            comboBoxCategory.UseSelectable = true;
            // 
            // dateTimeDueDate
            // 
            dateTimeDueDate.Location = new Point(180, 204);
            dateTimeDueDate.MinimumSize = new Size(0, 29);
            dateTimeDueDate.Name = "dateTimeDueDate";
            dateTimeDueDate.Size = new Size(442, 29);
            dateTimeDueDate.TabIndex = 8;
            // 
            // textBoxTitle
            // 
            textBoxTitle.BackColor = SystemColors.Window;
            textBoxTitle.BorderColor = Color.LightGray;
            textBoxTitle.BorderFocusColor = Color.CornflowerBlue;
            textBoxTitle.BorderRadius = 0;
            textBoxTitle.BorderSize = 2;
            textBoxTitle.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTitle.ForeColor = Color.FromArgb(64, 64, 64);
            textBoxTitle.Location = new Point(180, 145);
            textBoxTitle.Margin = new Padding(4);
            textBoxTitle.Multiline = false;
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Padding = new Padding(10, 7, 10, 7);
            textBoxTitle.PasswordChar = false;
            textBoxTitle.PlaceholderColor = Color.DarkGray;
            textBoxTitle.PlaceholderText = "";
            textBoxTitle.Size = new Size(442, 31);
            textBoxTitle.TabIndex = 7;
            textBoxTitle.UnderlinedStyle = false;
            // 
            // labelPriority
            // 
            labelPriority.AutoSize = true;
            labelPriority.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelPriority.ForeColor = Color.White;
            labelPriority.Location = new Point(34, 316);
            labelPriority.Name = "labelPriority";
            labelPriority.Size = new Size(82, 25);
            labelPriority.TabIndex = 6;
            labelPriority.Text = "Priority :";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelCategory.ForeColor = Color.White;
            labelCategory.Location = new Point(34, 262);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(97, 25);
            labelCategory.TabIndex = 5;
            labelCategory.Text = "Category :";
            // 
            // labelDueDate
            // 
            labelDueDate.AutoSize = true;
            labelDueDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelDueDate.ForeColor = Color.White;
            labelDueDate.Location = new Point(34, 205);
            labelDueDate.Name = "labelDueDate";
            labelDueDate.Size = new Size(97, 25);
            labelDueDate.TabIndex = 4;
            labelDueDate.Text = "Due date :";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(34, 147);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(62, 25);
            labelTitle.TabIndex = 3;
            labelTitle.Text = "Title : ";
            // 
            // labelHeading
            // 
            labelHeading.AutoSize = true;
            labelHeading.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelHeading.ForeColor = Color.White;
            labelHeading.Location = new Point(265, 19);
            labelHeading.Name = "labelHeading";
            labelHeading.Size = new Size(123, 37);
            labelHeading.TabIndex = 0;
            labelHeading.Text = "Edit Task";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(9, 64, 103);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(closeButton);
            panel1.Controls.Add(buttonReset);
            panel1.Controls.Add(buttonUpdate);
            panel1.Controls.Add(comboBoxPriority);
            panel1.Controls.Add(comboBoxCategory);
            panel1.Controls.Add(dateTimeDueDate);
            panel1.Controls.Add(textBoxTitle);
            panel1.Controls.Add(labelPriority);
            panel1.Controls.Add(labelCategory);
            panel1.Controls.Add(labelDueDate);
            panel1.Controls.Add(labelTitle);
            panel1.Controls.Add(labelHeading);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(668, 466);
            panel1.TabIndex = 1;
            // 
            // EditTaskFormModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 466);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditTaskFormModal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditTaskFormModal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.SpaceClose closeButton;
        private CustomControls.RJControls.CustomButton buttonReset;
        private CustomControls.RJControls.CustomButton buttonUpdate;
        private ReaLTaiizor.Controls.PoisonComboBox comboBoxPriority;
        private ReaLTaiizor.Controls.PoisonComboBox comboBoxCategory;
        private ReaLTaiizor.Controls.PoisonDateTime dateTimeDueDate;
        private CustomControls.RJControls.CustomTextBox textBoxTitle;
        private Label labelPriority;
        private Label labelCategory;
        private Label labelDueDate;
        private Label labelTitle;
        private Label labelHeading;
        private Panel panel1;
    }
}
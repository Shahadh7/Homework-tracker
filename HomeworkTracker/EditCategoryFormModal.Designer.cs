namespace HomeworkTracker
{
    partial class EditCategoryFormModal
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
            panel1 = new Panel();
            closeButton = new ReaLTaiizor.Controls.SpaceClose();
            buttonUpdate = new CustomControls.RJControls.CustomButton();
            textBoxTitle = new CustomControls.RJControls.CustomTextBox();
            labelCategoryName = new Label();
            labelHeading = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(9, 64, 103);
            panel1.Controls.Add(closeButton);
            panel1.Controls.Add(buttonUpdate);
            panel1.Controls.Add(textBoxTitle);
            panel1.Controls.Add(labelCategoryName);
            panel1.Controls.Add(labelHeading);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(443, 251);
            panel1.TabIndex = 0;
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeButton.Customization = "DQ/S/xhh8/8yMjL/Kioq/x5/9/8ND9L//v7+/yMjI/8qKir/";
            closeButton.DefaultAnchor = true;
            closeButton.DefaultLocation = true;
            closeButton.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            closeButton.Image = null;
            closeButton.Location = new Point(402, 3);
            closeButton.Margin = new Padding(3, 20, 3, 3);
            closeButton.Name = "closeButton";
            closeButton.NoRounding = false;
            closeButton.Size = new Size(38, 35);
            closeButton.TabIndex = 26;
            closeButton.Text = "x";
            closeButton.Transparent = false;
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
            buttonUpdate.Location = new Point(241, 173);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(171, 40);
            buttonUpdate.TabIndex = 24;
            buttonUpdate.Text = "Update";
            buttonUpdate.TextColor = Color.White;
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
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
            textBoxTitle.Location = new Point(193, 100);
            textBoxTitle.Margin = new Padding(4);
            textBoxTitle.Multiline = false;
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Padding = new Padding(10, 7, 10, 7);
            textBoxTitle.PasswordChar = false;
            textBoxTitle.PlaceholderColor = Color.DarkGray;
            textBoxTitle.PlaceholderText = "";
            textBoxTitle.Size = new Size(219, 31);
            textBoxTitle.TabIndex = 20;
            textBoxTitle.UnderlinedStyle = false;
            // 
            // labelCategoryName
            // 
            labelCategoryName.AutoSize = true;
            labelCategoryName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelCategoryName.ForeColor = Color.White;
            labelCategoryName.Location = new Point(34, 100);
            labelCategoryName.Name = "labelCategoryName";
            labelCategoryName.Size = new Size(152, 25);
            labelCategoryName.TabIndex = 16;
            labelCategoryName.Text = "Category Name :";
            // 
            // labelHeading
            // 
            labelHeading.AutoSize = true;
            labelHeading.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelHeading.ForeColor = Color.White;
            labelHeading.Location = new Point(116, 10);
            labelHeading.Name = "labelHeading";
            labelHeading.Size = new Size(183, 37);
            labelHeading.TabIndex = 15;
            labelHeading.Text = "Edit Category";
            // 
            // EditCategoryFormModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 251);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditCategoryFormModal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditCategoryFormModal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.SpaceClose closeButton;
        private CustomControls.RJControls.CustomButton buttonUpdate;
        private CustomControls.RJControls.CustomTextBox textBoxTitle;
        private Label labelCategoryName;
        private Label labelHeading;
    }
}
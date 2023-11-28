namespace HomeworkTracker
{
    partial class EditProgress
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
            textBoxProgress = new CustomControls.RJControls.CustomTextBox();
            labelProgress = new Label();
            labelHeading = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(9, 64, 103);
            panel1.Controls.Add(closeButton);
            panel1.Controls.Add(buttonUpdate);
            panel1.Controls.Add(textBoxProgress);
            panel1.Controls.Add(labelProgress);
            panel1.Controls.Add(labelHeading);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(427, 212);
            panel1.TabIndex = 1;
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeButton.Customization = "DQ/S/xhh8/8yMjL/Kioq/x5/9/8ND9L//v7+/yMjI/8qKir/";
            closeButton.DefaultAnchor = true;
            closeButton.DefaultLocation = true;
            closeButton.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            closeButton.Image = null;
            closeButton.Location = new Point(386, 3);
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
            buttonUpdate.Location = new Point(241, 153);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(171, 40);
            buttonUpdate.TabIndex = 24;
            buttonUpdate.Text = "Update";
            buttonUpdate.TextColor = Color.White;
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // textBoxProgress
            // 
            textBoxProgress.BackColor = SystemColors.Window;
            textBoxProgress.BorderColor = Color.LightGray;
            textBoxProgress.BorderFocusColor = Color.CornflowerBlue;
            textBoxProgress.BorderRadius = 0;
            textBoxProgress.BorderSize = 2;
            textBoxProgress.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxProgress.ForeColor = Color.FromArgb(64, 64, 64);
            textBoxProgress.Location = new Point(135, 100);
            textBoxProgress.Margin = new Padding(4);
            textBoxProgress.Multiline = false;
            textBoxProgress.Name = "textBoxProgress";
            textBoxProgress.Padding = new Padding(10, 7, 10, 7);
            textBoxProgress.PasswordChar = false;
            textBoxProgress.PlaceholderColor = Color.DarkGray;
            textBoxProgress.PlaceholderText = "";
            textBoxProgress.Size = new Size(277, 31);
            textBoxProgress.TabIndex = 20;
            textBoxProgress.Text = "";
            textBoxProgress.UnderlinedStyle = false;
            // 
            // labelProgress
            // 
            labelProgress.AutoSize = true;
            labelProgress.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelProgress.ForeColor = Color.White;
            labelProgress.Location = new Point(34, 100);
            labelProgress.Name = "labelProgress";
            labelProgress.Size = new Size(94, 25);
            labelProgress.TabIndex = 16;
            labelProgress.Text = "Progress :";
            // 
            // labelHeading
            // 
            labelHeading.AutoSize = true;
            labelHeading.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelHeading.ForeColor = Color.White;
            labelHeading.Location = new Point(113, 10);
            labelHeading.Name = "labelHeading";
            labelHeading.Size = new Size(219, 37);
            labelHeading.TabIndex = 15;
            labelHeading.Text = "Update Progress";
            // 
            // EditProgress
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 212);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditProgress";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditProgress";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.SpaceClose closeButton;
        private CustomControls.RJControls.CustomButton buttonUpdate;
        private CustomControls.RJControls.CustomTextBox textBoxProgress;
        private Label labelProgress;
        private Label labelHeading;
    }
}
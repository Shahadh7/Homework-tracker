namespace HomeworkTracker.CustomControls
{
    partial class TaskWithProgress
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblDueDate = new Label();
            progressBar = new ProgressBar();
            editBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)editBtn).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(20, 13);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(44, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "title";
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(23, 41);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(51, 15);
            lblDueDate.TabIndex = 1;
            lblDueDate.Text = "dueDate";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(435, 21);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(193, 23);
            progressBar.TabIndex = 2;
            // 
            // editBtn
            // 
            editBtn.Image = Properties.Resources.Pencil_Drawing;
            editBtn.Location = new Point(641, 13);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(47, 40);
            editBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            editBtn.TabIndex = 3;
            editBtn.TabStop = false;
            editBtn.Click += editBtn_Click;
            // 
            // TaskWithProgress
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(editBtn);
            Controls.Add(progressBar);
            Controls.Add(lblDueDate);
            Controls.Add(lblTitle);
            Name = "TaskWithProgress";
            Size = new Size(700, 66);
            ((System.ComponentModel.ISupportInitialize)editBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblDueDate;
        private ProgressBar progressBar;
        private PictureBox editBtn;
    }
}

namespace CustomControlsProject.CustomControls
{
    partial class TaskControl
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
            lblTask = new Label();
            toggleCompleted = new ToggleButton();
            deleteButton = new PictureBox();
            lblDueDate = new Label();
            editButton = new PictureBox();
            badge1 = new ReaLTaiizor.Controls.Badge();
            lblcat = new Label();
            lblCategory = new Label();
            progressBar = new ProgressBar();
            percentageLabel = new ReaLTaiizor.Controls.SpaceLabel();
            ((System.ComponentModel.ISupportInitialize)deleteButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)editButton).BeginInit();
            SuspendLayout();
            // 
            // lblTask
            // 
            lblTask.AutoSize = true;
            lblTask.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTask.Location = new Point(21, 8);
            lblTask.Name = "lblTask";
            lblTask.RightToLeft = RightToLeft.No;
            lblTask.Size = new Size(97, 25);
            lblTask.TabIndex = 0;
            lblTask.Text = "TaskName";
            // 
            // toggleCompleted
            // 
            toggleCompleted.Cursor = Cursors.Hand;
            toggleCompleted.Location = new Point(604, 39);
            toggleCompleted.MinimumSize = new Size(45, 22);
            toggleCompleted.Name = "toggleCompleted";
            toggleCompleted.OffBackroundColor = Color.Gray;
            toggleCompleted.OffToggleColor = Color.Gainsboro;
            toggleCompleted.OnBackroundColor = Color.MediumSlateBlue;
            toggleCompleted.OnToggleColor = Color.WhiteSmoke;
            toggleCompleted.Size = new Size(71, 25);
            toggleCompleted.TabIndex = 1;
            toggleCompleted.UseVisualStyleBackColor = true;
            toggleCompleted.MouseClick += toggleCompleted_MouseClick;
            // 
            // deleteButton
            // 
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.Image = HomeworkTracker.Properties.Resources.Remove;
            deleteButton.Location = new Point(557, 31);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(41, 39);
            deleteButton.SizeMode = PictureBoxSizeMode.StretchImage;
            deleteButton.TabIndex = 2;
            deleteButton.TabStop = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // lblDueDate
            // 
            lblDueDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDueDate.Location = new Point(23, 39);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(138, 20);
            lblDueDate.TabIndex = 3;
            lblDueDate.Text = "dueDate";
            // 
            // editButton
            // 
            editButton.Cursor = Cursors.Hand;
            editButton.Image = HomeworkTracker.Properties.Resources.Pencil_Drawing;
            editButton.Location = new Point(510, 31);
            editButton.Name = "editButton";
            editButton.Size = new Size(41, 39);
            editButton.SizeMode = PictureBoxSizeMode.StretchImage;
            editButton.TabIndex = 4;
            editButton.TabStop = false;
            editButton.Click += editButton_Click;
            // 
            // badge1
            // 
            badge1.BGColorA = Color.FromArgb(197, 69, 68);
            badge1.BGColorB = Color.FromArgb(176, 52, 52);
            badge1.BorderColor = Color.FromArgb(205, 70, 66);
            badge1.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            badge1.ForeColor = Color.FromArgb(176, 52, 52);
            badge1.Location = new Point(282, 49);
            badge1.Maximum = 9;
            badge1.Name = "badge1";
            badge1.Size = new Size(17, 18);
            badge1.TabIndex = 6;
            badge1.Text = "badge1";
            badge1.Value = 0;
            // 
            // lblcat
            // 
            lblcat.AutoSize = true;
            lblcat.Location = new Point(26, 68);
            lblcat.Name = "lblcat";
            lblcat.Size = new Size(61, 15);
            lblcat.TabIndex = 7;
            lblcat.Text = "Category: ";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(89, 69);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(23, 15);
            lblCategory.TabIndex = 8;
            lblCategory.Text = "cat";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(305, 49);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(199, 20);
            progressBar.TabIndex = 9;
            // 
            // percentageLabel
            // 
            percentageLabel.Customization = "/v7+/yoqKv8=";
            percentageLabel.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
            percentageLabel.Image = null;
            percentageLabel.Location = new Point(463, 31);
            percentageLabel.Name = "percentageLabel";
            percentageLabel.NoRounding = false;
            percentageLabel.Size = new Size(41, 17);
            percentageLabel.TabIndex = 10;
            percentageLabel.TextAlignment = HorizontalAlignment.Center;
            percentageLabel.Transparent = false;
            // 
            // TaskControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(percentageLabel);
            Controls.Add(progressBar);
            Controls.Add(lblCategory);
            Controls.Add(lblcat);
            Controls.Add(badge1);
            Controls.Add(editButton);
            Controls.Add(lblDueDate);
            Controls.Add(deleteButton);
            Controls.Add(toggleCompleted);
            Controls.Add(lblTask);
            Name = "TaskControl";
            Size = new Size(690, 100);
            ((System.ComponentModel.ISupportInitialize)deleteButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)editButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTask;
        private ToggleButton toggleCompleted;
        private PictureBox deleteButton;
        private Label lblDueDate;
        private PictureBox editButton;
        private ReaLTaiizor.Controls.Badge badge1;
        private Label lblcat;
        private Label lblCategory;
        private ProgressBar progressBar;
        private ReaLTaiizor.Controls.SpaceLabel percentageLabel;
    }
}

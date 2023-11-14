namespace HomeworkTracker
{
    partial class AppContainer
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
            navPanel = new Panel();
            label1 = new Label();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            sidePanel = new Panel();
            panel1 = new Panel();
            buttonLogout = new Button();
            panelProgress = new Panel();
            buttonProgress = new Button();
            panelDashboard = new Panel();
            buttonDashboard = new Button();
            panelTask = new Panel();
            buttonTask = new Button();
            panelCategory = new Panel();
            buttonCategory = new Button();
            flPanelMain = new Panel();
            navPanel.SuspendLayout();
            sidePanel.SuspendLayout();
            panel1.SuspendLayout();
            panelProgress.SuspendLayout();
            panelDashboard.SuspendLayout();
            panelTask.SuspendLayout();
            panelCategory.SuspendLayout();
            SuspendLayout();
            // 
            // navPanel
            // 
            navPanel.BackColor = Color.White;
            navPanel.Controls.Add(label1);
            navPanel.Controls.Add(nightControlBox1);
            navPanel.Dock = DockStyle.Top;
            navPanel.Location = new Point(0, 0);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(998, 33);
            navPanel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 7);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 3;
            label1.Text = "HOMEWORK TRACKER";
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(859, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 3;
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(9, 64, 103);
            sidePanel.Controls.Add(panel1);
            sidePanel.Controls.Add(panelProgress);
            sidePanel.Controls.Add(panelDashboard);
            sidePanel.Controls.Add(panelTask);
            sidePanel.Controls.Add(panelCategory);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 33);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(238, 783);
            sidePanel.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonLogout);
            panel1.Location = new Point(0, 254);
            panel1.Name = "panel1";
            panel1.Size = new Size(238, 50);
            panel1.TabIndex = 6;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.FromArgb(9, 64, 103);
            buttonLogout.FlatAppearance.BorderSize = 0;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogout.ForeColor = Color.White;
            buttonLogout.Location = new Point(0, 0);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Padding = new Padding(10, 0, 0, 0);
            buttonLogout.Size = new Size(238, 50);
            buttonLogout.TabIndex = 4;
            buttonLogout.Text = "Logout";
            buttonLogout.TextAlign = ContentAlignment.MiddleLeft;
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += button1_Click;
            // 
            // panelProgress
            // 
            panelProgress.Controls.Add(buttonProgress);
            panelProgress.Location = new Point(0, 198);
            panelProgress.Name = "panelProgress";
            panelProgress.Size = new Size(238, 50);
            panelProgress.TabIndex = 5;
            // 
            // buttonProgress
            // 
            buttonProgress.BackColor = Color.FromArgb(9, 64, 103);
            buttonProgress.FlatAppearance.BorderSize = 0;
            buttonProgress.FlatStyle = FlatStyle.Flat;
            buttonProgress.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonProgress.ForeColor = Color.White;
            buttonProgress.Location = new Point(0, 0);
            buttonProgress.Name = "buttonProgress";
            buttonProgress.Padding = new Padding(10, 0, 0, 0);
            buttonProgress.Size = new Size(238, 50);
            buttonProgress.TabIndex = 4;
            buttonProgress.Text = "Progress Tracking";
            buttonProgress.TextAlign = ContentAlignment.MiddleLeft;
            buttonProgress.UseVisualStyleBackColor = false;
            buttonProgress.Click += buttonProgress_Click;
            // 
            // panelDashboard
            // 
            panelDashboard.Controls.Add(buttonDashboard);
            panelDashboard.Location = new Point(0, 30);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(238, 50);
            panelDashboard.TabIndex = 3;
            // 
            // buttonDashboard
            // 
            buttonDashboard.BackColor = Color.FromArgb(9, 64, 103);
            buttonDashboard.FlatAppearance.BorderSize = 0;
            buttonDashboard.FlatStyle = FlatStyle.Flat;
            buttonDashboard.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDashboard.ForeColor = Color.White;
            buttonDashboard.Location = new Point(0, 0);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Padding = new Padding(10, 0, 0, 0);
            buttonDashboard.Size = new Size(238, 50);
            buttonDashboard.TabIndex = 4;
            buttonDashboard.Text = "Dashboard";
            buttonDashboard.TextAlign = ContentAlignment.MiddleLeft;
            buttonDashboard.UseVisualStyleBackColor = false;
            buttonDashboard.Click += buttonDashboard_Click;
            // 
            // panelTask
            // 
            panelTask.Controls.Add(buttonTask);
            panelTask.Location = new Point(0, 86);
            panelTask.Name = "panelTask";
            panelTask.Size = new Size(238, 50);
            panelTask.TabIndex = 5;
            // 
            // buttonTask
            // 
            buttonTask.BackColor = Color.FromArgb(9, 64, 103);
            buttonTask.FlatAppearance.BorderSize = 0;
            buttonTask.FlatStyle = FlatStyle.Flat;
            buttonTask.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTask.ForeColor = Color.White;
            buttonTask.Location = new Point(0, 0);
            buttonTask.Name = "buttonTask";
            buttonTask.Padding = new Padding(10, 0, 0, 0);
            buttonTask.Size = new Size(238, 50);
            buttonTask.TabIndex = 4;
            buttonTask.Text = "Task Management";
            buttonTask.TextAlign = ContentAlignment.MiddleLeft;
            buttonTask.UseVisualStyleBackColor = false;
            buttonTask.Click += buttonTask_Click;
            // 
            // panelCategory
            // 
            panelCategory.Controls.Add(buttonCategory);
            panelCategory.Location = new Point(0, 142);
            panelCategory.Name = "panelCategory";
            panelCategory.Size = new Size(238, 50);
            panelCategory.TabIndex = 5;
            // 
            // buttonCategory
            // 
            buttonCategory.BackColor = Color.FromArgb(9, 64, 103);
            buttonCategory.FlatAppearance.BorderSize = 0;
            buttonCategory.FlatStyle = FlatStyle.Flat;
            buttonCategory.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCategory.ForeColor = Color.White;
            buttonCategory.Location = new Point(0, 0);
            buttonCategory.Name = "buttonCategory";
            buttonCategory.Padding = new Padding(10, 0, 0, 0);
            buttonCategory.Size = new Size(238, 50);
            buttonCategory.TabIndex = 4;
            buttonCategory.Text = "Category Management";
            buttonCategory.TextAlign = ContentAlignment.MiddleLeft;
            buttonCategory.UseVisualStyleBackColor = false;
            buttonCategory.Click += buttonCategory_Click;
            // 
            // flPanelMain
            // 
            flPanelMain.Dock = DockStyle.Fill;
            flPanelMain.Location = new Point(238, 33);
            flPanelMain.Name = "flPanelMain";
            flPanelMain.Size = new Size(760, 783);
            flPanelMain.TabIndex = 6;
            // 
            // Container
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 816);
            Controls.Add(flPanelMain);
            Controls.Add(sidePanel);
            Controls.Add(navPanel);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "Container";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Container";
            navPanel.ResumeLayout(false);
            navPanel.PerformLayout();
            sidePanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panelProgress.ResumeLayout(false);
            panelDashboard.ResumeLayout(false);
            panelTask.ResumeLayout(false);
            panelCategory.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel navPanel;
        private Panel sidePanel;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Panel panelDashboard;
        private Button buttonDashboard;
        private Panel panelTask;
        private Button buttonTask;
        private Panel panelCategory;
        private Button buttonCategory;
        private Panel panelProgress;
        private Button buttonProgress;
        private Label label1;
        private Panel flPanelMain;
        private Panel panel1;
        private Button buttonLogout;
    }
}
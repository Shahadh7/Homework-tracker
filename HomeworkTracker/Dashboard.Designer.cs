namespace HomeworkTracker
{
    partial class Dashboard
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
            panelCompletedTasks = new FlowLayoutPanel();
            nightLabel1 = new ReaLTaiizor.Controls.NightLabel();
            nightLabel2 = new ReaLTaiizor.Controls.NightLabel();
            SuspendLayout();
            // 
            // panelPendingTasks
            // 
            panelPendingTasks.AutoScroll = true;
            panelPendingTasks.BackColor = Color.FromArgb(216, 238, 254);
            panelPendingTasks.Location = new Point(24, 49);
            panelPendingTasks.Name = "panelPendingTasks";
            panelPendingTasks.Size = new Size(712, 340);
            panelPendingTasks.TabIndex = 0;
            // 
            // panelCompletedTasks
            // 
            panelCompletedTasks.AutoScroll = true;
            panelCompletedTasks.BackColor = Color.FromArgb(216, 238, 254);
            panelCompletedTasks.Location = new Point(24, 423);
            panelCompletedTasks.Name = "panelCompletedTasks";
            panelCompletedTasks.Size = new Size(712, 340);
            panelCompletedTasks.TabIndex = 2;
            // 
            // nightLabel1
            // 
            nightLabel1.AutoSize = true;
            nightLabel1.BackColor = Color.Transparent;
            nightLabel1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nightLabel1.ForeColor = Color.FromArgb(114, 118, 127);
            nightLabel1.Location = new Point(34, 25);
            nightLabel1.Name = "nightLabel1";
            nightLabel1.Size = new Size(218, 21);
            nightLabel1.TabIndex = 4;
            nightLabel1.Text = "Today's Pending Homeworks";
            // 
            // nightLabel2
            // 
            nightLabel2.AutoSize = true;
            nightLabel2.BackColor = Color.Transparent;
            nightLabel2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nightLabel2.ForeColor = Color.FromArgb(114, 118, 127);
            nightLabel2.Location = new Point(34, 399);
            nightLabel2.Name = "nightLabel2";
            nightLabel2.Size = new Size(184, 21);
            nightLabel2.TabIndex = 5;
            nightLabel2.Text = "Completed Homeworks";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 238, 254);
            ClientSize = new Size(760, 783);
            ControlBox = false;
            Controls.Add(nightLabel2);
            Controls.Add(nightLabel1);
            Controls.Add(panelCompletedTasks);
            Controls.Add(panelPendingTasks);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel panelPendingTasks;
        private FlowLayoutPanel panelCompletedTasks;
        private ReaLTaiizor.Controls.NightLabel nightLabel1;
        private ReaLTaiizor.Controls.NightLabel nightLabel2;
    }
}
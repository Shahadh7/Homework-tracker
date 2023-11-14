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
            flowLayoutPanel1 = new FlowLayoutPanel();
            task1 = new CustomControlsProject.CustomControls.task();
            task2 = new CustomControlsProject.CustomControls.task();
            task3 = new CustomControlsProject.CustomControls.task();
            task4 = new CustomControlsProject.CustomControls.task();
            flowLayoutPanel2 = new FlowLayoutPanel();
            nightLabel1 = new ReaLTaiizor.Controls.NightLabel();
            nightLabel2 = new ReaLTaiizor.Controls.NightLabel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(216, 238, 254);
            flowLayoutPanel1.Controls.Add(task1);
            flowLayoutPanel1.Controls.Add(task2);
            flowLayoutPanel1.Controls.Add(task3);
            flowLayoutPanel1.Controls.Add(task4);
            flowLayoutPanel1.Location = new Point(24, 49);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(712, 340);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // task1
            // 
            task1.BackColor = Color.White;
            task1.Completed = false;
            task1.Data = null;
            task1.Location = new Point(10, 10);
            task1.Margin = new Padding(10, 10, 10, 3);
            task1.Name = "task1";
            task1.Size = new Size(690, 68);
            task1.TabIndex = 0;
            task1.Title = null;
            // 
            // task2
            // 
            task2.BackColor = Color.White;
            task2.Completed = false;
            task2.Data = null;
            task2.Location = new Point(10, 91);
            task2.Margin = new Padding(10, 10, 10, 3);
            task2.Name = "task2";
            task2.Size = new Size(690, 68);
            task2.TabIndex = 1;
            task2.Title = null;
            // 
            // task3
            // 
            task3.BackColor = Color.White;
            task3.Completed = false;
            task3.Data = null;
            task3.Location = new Point(10, 172);
            task3.Margin = new Padding(10, 10, 10, 3);
            task3.Name = "task3";
            task3.Size = new Size(690, 68);
            task3.TabIndex = 2;
            task3.Title = null;
            // 
            // task4
            // 
            task4.BackColor = Color.White;
            task4.Completed = false;
            task4.Data = null;
            task4.Location = new Point(10, 253);
            task4.Margin = new Padding(10, 10, 10, 3);
            task4.Name = "task4";
            task4.Size = new Size(690, 68);
            task4.TabIndex = 3;
            task4.Title = null;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(216, 238, 254);
            flowLayoutPanel2.Location = new Point(24, 423);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(712, 340);
            flowLayoutPanel2.TabIndex = 2;
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
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            Text = "Dashboard";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private CustomControlsProject.CustomControls.task task1;
        private CustomControlsProject.CustomControls.task task2;
        private CustomControlsProject.CustomControls.task task3;
        private CustomControlsProject.CustomControls.task task4;
        private ReaLTaiizor.Controls.NightLabel nightLabel1;
        private ReaLTaiizor.Controls.NightLabel nightLabel2;
    }
}
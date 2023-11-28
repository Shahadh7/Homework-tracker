namespace HomeworkTracker
{
    partial class ProgressTracking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressTracking));
            labelHeading = new Label();
            pieChartCard = new ReaLTaiizor.Controls.MaterialCard();
            todaysDate = new Label();
            label2 = new Label();
            label1 = new Label();
            badge2 = new ReaLTaiizor.Controls.Badge();
            badge1 = new ReaLTaiizor.Controls.Badge();
            parrotPieGraph1 = new ReaLTaiizor.Controls.ParrotPieGraph();
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            todaysDate2 = new Label();
            RemainingCount = new Label();
            completedCount = new Label();
            foxBigLabel2 = new ReaLTaiizor.Controls.FoxBigLabel();
            foxBigLabel1 = new ReaLTaiizor.Controls.FoxBigLabel();
            flpTasksList = new FlowLayoutPanel();
            pieChartCard.SuspendLayout();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // labelHeading
            // 
            labelHeading.AutoSize = true;
            labelHeading.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelHeading.Location = new Point(245, 9);
            labelHeading.Name = "labelHeading";
            labelHeading.Size = new Size(250, 40);
            labelHeading.TabIndex = 7;
            labelHeading.Text = "Progress Tracking";
            // 
            // pieChartCard
            // 
            pieChartCard.BackColor = Color.FromArgb(255, 255, 255);
            pieChartCard.Controls.Add(todaysDate);
            pieChartCard.Controls.Add(label2);
            pieChartCard.Controls.Add(label1);
            pieChartCard.Controls.Add(badge2);
            pieChartCard.Controls.Add(badge1);
            pieChartCard.Controls.Add(parrotPieGraph1);
            pieChartCard.Depth = 0;
            pieChartCard.ForeColor = Color.FromArgb(222, 0, 0, 0);
            pieChartCard.Location = new Point(64, 90);
            pieChartCard.Margin = new Padding(14);
            pieChartCard.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            pieChartCard.Name = "pieChartCard";
            pieChartCard.Padding = new Padding(14);
            pieChartCard.Size = new Size(286, 233);
            pieChartCard.TabIndex = 8;
            // 
            // todaysDate
            // 
            todaysDate.AutoSize = true;
            todaysDate.Location = new Point(21, 14);
            todaysDate.Name = "todaysDate";
            todaysDate.Size = new Size(30, 15);
            todaysDate.TabIndex = 5;
            todaysDate.Text = "date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 204);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Pending";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 204);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 3;
            label1.Text = "Completed";
            // 
            // badge2
            // 
            badge2.BackColor = Color.Red;
            badge2.BGColorA = Color.Red;
            badge2.BGColorB = Color.Red;
            badge2.BorderColor = Color.Red;
            badge2.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            badge2.ForeColor = Color.Red;
            badge2.Location = new Point(173, 201);
            badge2.Maximum = 9;
            badge2.Name = "badge2";
            badge2.Size = new Size(20, 20);
            badge2.TabIndex = 2;
            badge2.Text = "badge2";
            badge2.Value = 0;
            // 
            // badge1
            // 
            badge1.BackColor = Color.FromArgb(0, 150, 212);
            badge1.BGColorA = Color.FromArgb(0, 150, 212);
            badge1.BGColorB = Color.FromArgb(0, 150, 212);
            badge1.BorderColor = Color.FromArgb(0, 150, 212);
            badge1.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            badge1.ForeColor = Color.FromArgb(0, 150, 212);
            badge1.Location = new Point(39, 201);
            badge1.Maximum = 9;
            badge1.Name = "badge1";
            badge1.Size = new Size(20, 20);
            badge1.TabIndex = 1;
            badge1.Text = "badge1";
            badge1.Value = 0;
            // 
            // parrotPieGraph1
            // 
            parrotPieGraph1.BackColor = Color.White;
            parrotPieGraph1.Colors = (List<Color>)resources.GetObject("parrotPieGraph1.Colors");
            parrotPieGraph1.Location = new Point(59, 29);
            parrotPieGraph1.Name = "parrotPieGraph1";
            parrotPieGraph1.Numbers = (List<int>)resources.GetObject("parrotPieGraph1.Numbers");
            parrotPieGraph1.RightToLeft = RightToLeft.No;
            parrotPieGraph1.Size = new Size(160, 163);
            parrotPieGraph1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotPieGraph1.TabIndex = 0;
            parrotPieGraph1.Text = "parrotPieGraph1";
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(todaysDate2);
            materialCard1.Controls.Add(RemainingCount);
            materialCard1.Controls.Add(completedCount);
            materialCard1.Controls.Add(foxBigLabel2);
            materialCard1.Controls.Add(foxBigLabel1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(406, 90);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(286, 233);
            materialCard1.TabIndex = 9;
            // 
            // todaysDate2
            // 
            todaysDate2.AutoSize = true;
            todaysDate2.Location = new Point(27, 14);
            todaysDate2.Name = "todaysDate2";
            todaysDate2.Size = new Size(30, 15);
            todaysDate2.TabIndex = 6;
            todaysDate2.Text = "date";
            // 
            // RemainingCount
            // 
            RemainingCount.AutoSize = true;
            RemainingCount.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            RemainingCount.ForeColor = Color.FromArgb(76, 88, 100);
            RemainingCount.Location = new Point(220, 145);
            RemainingCount.Name = "RemainingCount";
            RemainingCount.Size = new Size(33, 37);
            RemainingCount.TabIndex = 3;
            RemainingCount.Text = "0";
            // 
            // completedCount
            // 
            completedCount.AutoSize = true;
            completedCount.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            completedCount.ForeColor = Color.FromArgb(76, 88, 100);
            completedCount.Location = new Point(219, 48);
            completedCount.Name = "completedCount";
            completedCount.Size = new Size(33, 37);
            completedCount.TabIndex = 2;
            completedCount.Text = "0";
            // 
            // foxBigLabel2
            // 
            foxBigLabel2.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            foxBigLabel2.ForeColor = Color.FromArgb(76, 88, 100);
            foxBigLabel2.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            foxBigLabel2.LineColor = Color.FromArgb(200, 200, 200);
            foxBigLabel2.Location = new Point(27, 138);
            foxBigLabel2.Name = "foxBigLabel2";
            foxBigLabel2.Size = new Size(165, 51);
            foxBigLabel2.TabIndex = 1;
            foxBigLabel2.Text = "Remaining : ";
            // 
            // foxBigLabel1
            // 
            foxBigLabel1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            foxBigLabel1.ForeColor = Color.FromArgb(76, 88, 100);
            foxBigLabel1.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            foxBigLabel1.LineColor = Color.FromArgb(200, 200, 200);
            foxBigLabel1.Location = new Point(27, 43);
            foxBigLabel1.Name = "foxBigLabel1";
            foxBigLabel1.Size = new Size(165, 51);
            foxBigLabel1.TabIndex = 0;
            foxBigLabel1.Text = "Completed : ";
            // 
            // flpTasksList
            // 
            flpTasksList.Location = new Point(12, 362);
            flpTasksList.Name = "flpTasksList";
            flpTasksList.Size = new Size(736, 400);
            flpTasksList.TabIndex = 10;
            // 
            // ProgressTracking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 238, 254);
            ClientSize = new Size(760, 783);
            ControlBox = false;
            Controls.Add(flpTasksList);
            Controls.Add(materialCard1);
            Controls.Add(pieChartCard);
            Controls.Add(labelHeading);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProgressTracking";
            Text = "ProgressTracking";
            Load += ProgressTracking_Load;
            pieChartCard.ResumeLayout(false);
            pieChartCard.PerformLayout();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHeading;
        private ReaLTaiizor.Controls.MaterialCard pieChartCard;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private ReaLTaiizor.Controls.ParrotPieGraph parrotPieGraph1;
        private Label label2;
        private Label label1;
        private ReaLTaiizor.Controls.Badge badge2;
        private ReaLTaiizor.Controls.Badge badge1;
        private Label todaysDate;
        private Label todaysDate2;
        private Label RemainingCount;
        private Label completedCount;
        private ReaLTaiizor.Controls.FoxBigLabel foxBigLabel2;
        private ReaLTaiizor.Controls.FoxBigLabel foxBigLabel1;
        private FlowLayoutPanel flpTasksList;
    }
}
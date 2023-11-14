using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkTracker
{
    public partial class AppContainer : Form
    {
        Dashboard? dashboard;
        TaskManagement? taskManagement;
        CategoryManagement? categoryManagement;
        ProgressTracking? progressTracking;

        public AppContainer()
        {
            InitializeComponent();
            showDashboard();
        }

        private void showDashboard()
        {
            dashboard = new Dashboard
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            dashboard.FormClosed += Dashboard_FormClosed;
            dashboard.Parent = this;
            this.flPanelMain.Controls.Add(dashboard);
            dashboard.Show();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            dashboard = null;
            dashboard = new Dashboard
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            dashboard.FormClosed += Dashboard_FormClosed;
            dashboard.Parent = this;
            this.flPanelMain.Controls.Clear();
            this.flPanelMain.Controls.Add(dashboard);
            dashboard.Show();
        }

        private void Dashboard_FormClosed(object? sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }

        private void buttonTask_Click(object sender, EventArgs e)
        {
            taskManagement = null;
            taskManagement = new TaskManagement
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            taskManagement.FormClosed += TaskManagement_FormClosed;
            this.flPanelMain.Controls.Clear();
            this.flPanelMain.Controls.Add(taskManagement);
            taskManagement.Show();
        }

        private void TaskManagement_FormClosed(object? sender, FormClosedEventArgs e)
        {
            taskManagement = null;
        }

        private void buttonCategory_Click(object sender, EventArgs e)
        {
            categoryManagement = null;
            categoryManagement = new CategoryManagement
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            categoryManagement.FormClosed += CategoryManagement_FormClosed;
            this.flPanelMain.Controls.Clear();
            this.flPanelMain.Controls.Add(categoryManagement);
            categoryManagement.Show();
        }

        private void CategoryManagement_FormClosed(object? sender, FormClosedEventArgs e)
        {
            categoryManagement = null;
        }

        private void buttonProgress_Click(object sender, EventArgs e)
        {
            progressTracking = null;
            progressTracking = new ProgressTracking
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            progressTracking.FormClosed += ProgressTracking_FormClosed;
            this.flPanelMain.Controls.Clear();
            this.flPanelMain.Controls.Add(progressTracking);
            progressTracking.Show();
        }

        private void ProgressTracking_FormClosed(object? sender, FormClosedEventArgs e)
        {
            progressTracking = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

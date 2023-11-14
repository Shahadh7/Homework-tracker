﻿using CustomControlsProject.CustomControls;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkTracker
{
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();
            
        }

        private void fetchAllPendingTasks()
        {
            DataAccess db = new DataAccess();
            List<Task> tasks = db.GetAllTodaysPendingTasks();

            if (tasks.Count > 0)
            {
                panelPendingTasks.Controls.Clear();
                foreach (Task task in tasks)
                {
                    TaskControl taskControl = new TaskControl();
                    taskControl.Completed = task.completed == 1 ? true : false;
                    taskControl.Title = task.title;
                    taskControl.DueDate = task.dueDate.ToString();
                    taskControl.Percentage = task.progressPercentage;
                    taskControl.ImportanceLevel = task.importanceLevelID.ToString();
                    taskControl.Data = task;
                    panelPendingTasks.Controls.Add(taskControl);
                    taskControl.TaskCompleted += OnTaskCompleted;
                }
            }
            else
            {
                panelPendingTasks.Controls.Clear();
                Label label = new Label();
                label.Width = 500;
                label.Text = "No ramaining tasks";
                panelPendingTasks.Controls.Add(label);
            }
        }

        private void fetchAllCompletedTasks()
        {
            DataAccess db = new DataAccess();
            List<Task> tasks = db.GetAllTodaysCompletedTasks();

            if (tasks.Count > 0)
            {
                panelCompletedTasks.Controls.Clear();
                foreach (Task task in tasks)
                {
                    TaskControl taskControl = new TaskControl();
                    taskControl.Completed = task.completed == 1 ? true : false;
                    taskControl.Title = task.title;
                    taskControl.DueDate = task.dueDate.ToString();
                    taskControl.Percentage = task.progressPercentage;
                    taskControl.ImportanceLevel = task.importanceLevelID.ToString();
                    taskControl.Data = task;
                    panelCompletedTasks.Controls.Add(taskControl);
                    taskControl.TaskCompleted += OnTaskCompleted;
                }
            }
            else
            {
                panelCompletedTasks.Controls.Clear();
                Label label = new();
                label.Text = "No data available";
                label.Width = 100;
                panelCompletedTasks.Controls.Add(label);
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            fetchAllPendingTasks();
            fetchAllCompletedTasks();
        }

        private void OnTaskCompleted(object sender, EventArgs e)
        {
            fetchAllPendingTasks();
            fetchAllCompletedTasks();
        }

    }
}

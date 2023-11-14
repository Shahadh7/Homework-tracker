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
    public partial class ProgressTracking : Form
    {
        public ProgressTracking()
        {
            InitializeComponent();
            parrotPieGraph1.Numbers[0] = 15;
            parrotPieGraph1.Numbers[1] = 85;

            Random rand = new Random();

            completedCount.Text = rand.Next(5,100).ToString();
            RemainingCount.Text = rand.Next(5, 100).ToString();

            var dateAndTime = DateTime.Now;
            var date = dateAndTime.Date;
            todaysDate.Text = date.ToShortDateString();
            todaysDate2.Text = date.ToShortDateString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTracker
{
    public class Task
    {
        public int taskID { get; set; }
        public string title { get; set; }
        public DateTime dueDate { get; set; }
        public int importanceLevelID { get; set; }
        public int progressPercentage { get; set; }
        public int completed { get; set; }
        public int studentID { get; set; }
        public int categoryID { get; set; }

    }
}

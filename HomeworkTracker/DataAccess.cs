using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HomeworkTracker
{
    public class DataAccess
    {

        //User Authentication related functions
        public void SignUp(string username, string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBHelper.connectionvalue("HWTracker")))
            {

                try
                {
                    var sqlCheck = "SELECT * FROM hwtracker.student WHERE studentName = @studentName";

                    List<Student> students = connection.Query<Student>(sqlCheck, new { studentName = username.ToLower() }).ToList();

                    if (students.Count == 0)
                    {
                        var sql = "INSERT INTO hwtracker.student (studentName, password) VALUES (@studentName, @password)";

                        var student = new Student() { studentName = username.ToLower(), password = password };

                        var affectedRows = connection.Execute(sql, student);

                        MessageBox.Show(affectedRows.ToString());

                        connection.Close();

                        if (affectedRows == 1)
                        {
                            MessageBox.Show("Account created succcessfully. Please login with your credentials");
                        }
                        else
                        {
                            MessageBox.Show("Error Creating an account. Try again later");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username Already exist please try another.");
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }    
        }

        public bool Login(string username, string password)
        {
            bool isValid = false;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBHelper.connectionvalue("HWTracker")))
            {

                try
                {
                    var sqlCheck = "SELECT * FROM hwtracker.student WHERE studentName = @studentName";

                    var studentExist = connection.QueryFirst<Student>(sqlCheck, new { studentName = username.ToLower() });

                    if (studentExist != null)
                    {
                        if(studentExist.password ==  password)
                        {
                            isValid = true;
                            globalVariables.currentStudent = studentExist;
                        }
                        else
                        {
                            MessageBox.Show("Username or password invalid");
                            isValid = false;
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("User does not exist.");
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                
            }

            return isValid;
        }


        //Task Management related functions

        public List<Task> GetAllPendingTasks()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBHelper.connectionvalue("HWTracker")))
            {

                List<Task> tasks = new List<Task>();

                try
                {
                    var sql = "SELECT * FROM hwtracker.task WHERE studentID = @studentID AND completed = @completed";
                    tasks = connection.Query<Task>(sql, new { studentID = globalVariables.currentStudent.studentID, completed = 0 }).ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                return tasks;
            }
        }

        public List<Task> GetAllCompletedTasks()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBHelper.connectionvalue("HWTracker")))
            {

                List<Task> tasks = new List<Task>();

                try
                {
                    var sqlCheck = "SELECT * FROM hwtracker.task WHERE studentID = @studentID AND completed = @completed";
                    tasks = connection.Query<Task>(sqlCheck, new { studentID = globalVariables.currentStudent.studentID, completed = 1 }).ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                return tasks;
            }
        }
        public List<Task> GetAllTodaysPendingTasks()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBHelper.connectionvalue("HWTracker")))
            {

                List<Task> tasks = new List<Task>();

                try
                {
                    var sqlCheck = "SELECT * FROM hwtracker.task WHERE studentID = @studentID AND dueDate = @currentDate AND completed = @completed";

                    var dateAndTime = DateTime.Now;
                    var date = dateAndTime.Date;
                    string currentDate = date.ToShortDateString();

                    tasks = connection.Query<Task>(sqlCheck, new { studentID = globalVariables.currentStudent.studentID, currentDate = currentDate, completed = 0 }).ToList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                return tasks;
            }
        }

        public List<Task> GetAllTodaysCompletedTasks()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBHelper.connectionvalue("HWTracker")))
            {

                List<Task> tasks = new List<Task>();

                try
                {
                    var sqlCheck = "SELECT * FROM hwtracker.task WHERE studentID = @studentID AND dueDate = @currentDate AND completed = @completed";

                    var dateAndTime = DateTime.Now;
                    var date = dateAndTime.Date;
                    string currentDate = date.ToShortDateString();

                    tasks = connection.Query<Task>(sqlCheck, new { studentID = globalVariables.currentStudent.studentID, currentDate = currentDate, completed = 1 }).ToList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                return tasks;
            }
        }

        public void ToggleCompleted(int completed, int taskID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBHelper.connectionvalue("HWTracker")))
            {

                try
                {
                    int progressPercentage;
                    if (completed == 1)
                    {
                        progressPercentage = 100;
                    }
                    else
                    {
                        progressPercentage = 0;
                    }
                    
                    var sql = "UPDATE hwtracker.task SET completed = @completed, progressPercentage = @progressPercentage WHERE taskID = @taskID";

                    var affectedRows = connection.Execute(sql, new { completed = completed , taskID = taskID, progressPercentage = progressPercentage });

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        public void RemoveTask(int taskID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBHelper.connectionvalue("HWTracker")))
            {

                try
                {
                    var sql = "DELETE FROM hwtracker.task  WHERE taskID = @taskID";
                    var affectedRows = connection.Execute(sql, new { taskID = taskID });
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        public void UpdateTask(Task task)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBHelper.connectionvalue("HWTracker")))
            {

                try
                {
                    var sql = "UPDATE hwtracker.task SET progressPercentage = @progressPercentage, " +
                               "title= @title, importanceLevelID = @importanceLevelID, dueDate = @dueDate ," +
                               "categoryID = @categoryID    WHERE taskID = @taskID";
                    var affectedRows = connection.Execute(sql, task);
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            if (task.progressPercentage == 100)
            {
                ToggleCompleted(1, task.taskID);
            }
        }




        //Category related functions
        public List<Category> getAllCategories()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBHelper.connectionvalue("HWTracker")))
            {

                List<Category> categories = new List<Category>();

                try
                {
                    var sql = "SELECT * FROM hwtracker.category WHERE studentID = @studentID";

                    categories = connection.Query<Category>(sql, new { studentID = globalVariables.currentStudent.studentID }).ToList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                return categories;
            }
        }


        //Imporatance Level related functions
        public List<ImportanceLevel> getAllImportanceLevels()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBHelper.connectionvalue("HWTracker")))
            {

                List<ImportanceLevel> importanceLevels = new List<ImportanceLevel>();

                try
                {
                    var sql = "SELECT * FROM hwtracker.importancelevel";
                    importanceLevels = connection.Query<ImportanceLevel>(sql).ToList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                return importanceLevels;
            }
        }

        

    }
}

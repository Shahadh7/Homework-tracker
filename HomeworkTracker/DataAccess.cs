using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace HomeworkTracker
{
    public class DataAccess
    {
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

    }
}

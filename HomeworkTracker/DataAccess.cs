﻿using Dapper;
using System.Data;
using System.Threading.Tasks;

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

                        string hashedPassword = PasswordHasher.hashPassword(password);

                        var sql = "INSERT INTO hwtracker.student (studentName, password) VALUES (@studentName, @password)";

                        var student = new Student() { studentName = username.ToLower(), password = hashedPassword };

                        var affectedRows = connection.Execute(sql, student);

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
                        if(PasswordHasher.verifyPassword(password, studentExist.password))
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
                    MessageBox.Show("User does not exist.");
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

                tasks.Sort((t1, t2) => {
                    if (t1.importanceLevelID != t2.importanceLevelID)
                    {
                        return t1.importanceLevelID.CompareTo(t2.importanceLevelID);
                    }
                    else
                    {
                        return t1.dueDate.CompareTo(t2.dueDate);
                    }
                });

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
                tasks.Sort((t1, t2) => {
                    if (t1.importanceLevelID != t2.importanceLevelID)
                    {
                        return t1.importanceLevelID.CompareTo(t2.importanceLevelID);
                    }
                    else
                    {
                        return t1.dueDate.CompareTo(t2.dueDate);
                    }
                });

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

                tasks.Sort((t1, t2) => {
                    if (t1.importanceLevelID != t2.importanceLevelID)
                    {
                        return t1.importanceLevelID.CompareTo(t2.importanceLevelID);
                    }
                    else
                    {
                        return t1.dueDate.CompareTo(t2.dueDate);
                    }
                });

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

                tasks.Sort((t1, t2) => {
                    if (t1.importanceLevelID != t2.importanceLevelID)
                    {
                        return t1.importanceLevelID.CompareTo(t2.importanceLevelID);
                    }
                    else
                    {
                        return t1.dueDate.CompareTo(t2.dueDate);
                    }
                });

                return tasks;
            }
        }

        public List<Task> GetTasksWithProgress()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBHelper.connectionvalue("HWTracker")))
            {

                List<Task> tasks = new List<Task>();

                try
                {
                    var sqlCheck = "SELECT * FROM hwtracker.task WHERE studentID = @studentID";

                    tasks = connection.Query<Task>(sqlCheck, new { studentID = globalVariables.currentStudent.studentID}).ToList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                tasks.Sort((t1, t2) => {
                    return t1.dueDate.CompareTo(t2.dueDate);
                });

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

        public void AddTask(Task task)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBHelper.connectionvalue("HWTracker")))
            {

                try
                {
                    var sql = "INSERT INTO hwtracker.task (title, dueDate, importanceLevelID, progressPercentage, completed, studentID, categoryID)" +
                                "VALUES (@title, @dueDate, @importanceLevelID, @progressPercentage, @completed, @studentID, @categoryID)";
                    var affectedRows = connection.Execute(sql, task);
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        public int completedTaskCount()
        {
            int count = 0;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBHelper.connectionvalue("HWTracker")))
            {

                try
                {
                    var sql = "SELECT COUNT(taskID) as taskCount FROM hwtracker.task WHERE completed = 1 AND studentID = @studentID ;";
                    var task = connection.QueryFirst(sql, new { studentID = globalVariables.currentStudent.studentID });
                    if(task != null)
                    {
                        count = task.taskCount;
                    }
                    
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            return count;
        }

        public int remainingTaskCount()
        {
            int count = 0;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBHelper.connectionvalue("HWTracker")))
            {

                try
                {
                    var sql = "SELECT COUNT(taskID) as taskCount FROM hwtracker.task WHERE completed = 0 AND studentID = @studentID;";
                    var task = connection.QueryFirst(sql, new { studentID = globalVariables.currentStudent.studentID });
                    if (task != null)
                    {
                        count = task.taskCount;
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            return count;
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

        public void AddCategory(Category category)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBHelper.connectionvalue("HWTracker")))
            {

                try
                {
                    var sql = "INSERT INTO hwtracker.category (name, studentID) VALUES (@name,@studentID)";
                    var affectedRows = connection.Execute(sql, category);
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        public void UpdateCategory(Category category)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBHelper.connectionvalue("HWTracker")))
            {

                try
                {
                    var sql = "UPDATE hwtracker.category SET name = @name WHERE categoryID = @categoryID";
                    var affectedRows = connection.Execute(sql, category);
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        public void RemoveCategory(int categoryID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBHelper.connectionvalue("HWTracker")))
            {

                try
                {
                    var sql = "DELETE FROM hwtracker.category  WHERE categoryID = @categoryID";
                    var affectedRows = connection.Execute(sql, new { categoryID = categoryID });
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        public bool isTaskExistsWithCategoryID(int categoryID)
        {
            bool isExist = false;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBHelper.connectionvalue("HWTracker")))
            {

                try
                {
                    var sqlCheck = "SELECT * FROM hwtracker.task WHERE categoryID = @categoryID";

                    var categories = connection.Query<Category>(sqlCheck, new { categoryID = categoryID});

                    if (categories.Any())
                    {
                        isExist = true;
                    }
                    else
                    {
                        isExist = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return isExist;
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

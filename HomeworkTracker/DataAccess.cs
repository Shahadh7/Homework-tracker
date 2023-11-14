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
        public List<Student> GetStudents()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBHelper.connectionvalue("HWTracker")))
            {
                return connection.Query<Student>("SELECT * from hwtracker.student").ToList();
            }
        }

        public void SignUp(string username, string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBHelper.connectionvalue("HWTracker")))
            {

                var sqlCheck = "SELECT * FROM hwtracker.student WHERE studentName = @studentName ";

                List<Student> students = connection.Query<Student>(sqlCheck, new { studentName = username.ToLower() }).ToList();

                if(students.Count == 0)
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
            }    
        }

        public static bool Login(string username, string password)
        {
            return false;
        }

    }
}

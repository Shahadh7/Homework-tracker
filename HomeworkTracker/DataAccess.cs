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

    }
}

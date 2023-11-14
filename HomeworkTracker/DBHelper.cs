

using System.Configuration;

namespace HomeworkTracker
{
    public static class DBHelper
    {
        public static string connectionvalue(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}

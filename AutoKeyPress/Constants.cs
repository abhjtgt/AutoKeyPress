using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AutoKeyPress
{
    static class Constants
    {
        public static string kProcess = ConfigurationManager.AppSettings["ProcessName"].ToString();
        public static string kUser = ConfigurationManager.AppSettings["User"].ToString();
        public static string kSleepTIme = ConfigurationManager.AppSettings["SleepTime"].ToString();
        public static string kKeys = ConfigurationManager.AppSettings["Keys"].ToString();
        public static string kTImes = ConfigurationManager.AppSettings["Count"].ToString();
    }
}

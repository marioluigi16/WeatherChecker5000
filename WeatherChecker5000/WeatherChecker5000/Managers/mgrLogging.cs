using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WeatherChecker5000.Managers
{
    public static class mgrLogging
    {
        public static void LogError(Exception ex, string errMsg = "")
        {
            try
            {
                File.AppendAllText("", "");
            }
            catch(Exception exLog)
            {
                
            }
        }
    }
}

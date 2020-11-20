using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WeatherChecker5000.Managers
{
    public static class MgrLogging
    {
        public static void LogError(Exception ex, string errMsg = "")
        {
            try
            {
                File.AppendAllText("", ex.Message + errMsg);
            }
            catch (Exception)
            {
                
            }
        }
    }
}

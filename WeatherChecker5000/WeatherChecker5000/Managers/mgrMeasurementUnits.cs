using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace WeatherChecker5000.Managers
{
    public static class mgrMeasurementUnits
    {
        private static ISettings mgrSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        public static string g_MeasurementUnit
        {
            get
            {
                return mgrSettings.GetValueOrDefault("MeasurementUnit", "F");
            }
            set
            {
                mgrSettings.AddOrUpdateValue("MeasurementUnit", value);
            }
        }

        public static string g_UnitTemp
        {
            get
            {
                switch(g_MeasurementUnit)
                {
                    case "F":
                        return "F";
                    case "C":
                        return "C";
                    case "K":
                        return "K";
                    default:
                        return "F";
                }
            }
        }

        public static string g_UnitSpeed
        {
            get
            {
                switch (g_MeasurementUnit)
                {
                    case "F":
                        return "MPH";
                    case "C":
                    case "K":
                        return "M/S";
                    default:
                        return "MPH";
                }
            }
        }

        public static string g_UnitPrecip
        {
            get
            {
                switch (g_MeasurementUnit)
                {
                    case "F":
                        return "F";
                    case "C":
                        return "C";
                    case "K":
                        return "K";
                    default:
                        return "F";
                }
            }
        }
    }
}

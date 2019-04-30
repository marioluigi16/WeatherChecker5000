using System;
using System.Collections.Generic;
using System.Text;
using AGITestBlank.Managers;
using Newtonsoft.Json;

namespace AGITestBlank.Models.Common
{
    public class Wind
    {
        public double speed { get; set; }
        public double deg { get; set; }

        [JsonIgnore]
        public string direction_txt //degree thresholds taken from http://snowfence.umn.edu/Components/winddirectionanddegreeswithouttable3.htm
        {
            get
            {
                if (deg >= 348.75)
                    return "N";
                else if (deg >= 326.25)
                    return "NNW";
                else if (deg >= 303.75)
                    return "NW";
                else if (deg >= 281.25)
                    return "WNW";
                else if (deg >= 258.75)
                    return "W";
                else if (deg >= 236.25)
                    return "WSW";
                else if (deg >= 213.75)
                    return "SW";
                else if (deg >= 191.25)
                    return "SSW";
                else if (deg >= 168.75)
                    return "S";
                else if (deg >= 146.25)
                    return "SSE";
                else if (deg >= 123.75)
                    return "SE";
                else if (deg >= 101.25)
                    return "ESE";
                else if (deg >= 78.75)
                    return "E";
                else if (deg >= 56.25)
                    return "ENE";
                else if (deg >= 33.75)
                    return "NE";
                else if (deg >= 11.25)
                    return "NNE";
                else
                    return "N";
            }
        }

        [JsonIgnore]
        public string speed_txt
        {
            get
            {
                return direction_txt + " @ " + Math.Round(speed).ToString() + " " + mgrMeasurementUnits.g_UnitSpeed;
            }
        }
    }
}

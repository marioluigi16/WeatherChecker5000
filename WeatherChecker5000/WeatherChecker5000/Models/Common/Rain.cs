﻿using System.Text.Json.Serialization;

namespace WeatherChecker5000.Models.Common
{
    public class Rain
    {
        [JsonPropertyName("3h")]
        public double amt3h { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularAspNetCore.Models
{
    public class WeatherForecastForClient
    {
        public string DateFormatted { get; set; }
        public string TemperatureC { get; set; }
        public string Summary { get; set; }

        public string TemperatureF
        {
            get;set;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grimstad_Weather_Application
{
     class weatherForecast
    {
        public class temp
        {
            public double day { get; set; }
        }

        public class weatherWW
        {
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }


        public class daily
        {
            public long dt { get; set; }
            public temp temp { get; set; }
            public List<WeatherInfo.weather> weather { get; set; }
        }


        public class forecastInfo
        {
            //public daily[] daily { get; set; }
            public List<daily> daily { get; set; }
        }
    }
}

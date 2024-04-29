﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grimstad_Weather_Application
{
    internal class Weather_Info
    {
        public class coord
        {
            double ion { get; set; }
            double lat { get; set; }
        }

        public class weather
        {
            string main { get; set; }
            string description { get; set; }
            string icon { get; }
        }

        public class main
        {
            double temp { get; set; }
            double feel_like { get; set; }
            double pressure { get; set; }
            double humidity { get; set; }
        }

        public class wind
        {
            double speed { get; set; }
        }

        public class sys
        {
            long sunrise { get; set; }
            long sunset { get; set; }
        }

        public class root
        {
            public coord coord { get; set; }
            public List <weather> Weather { get; set; }
            public main main { get; set; }

            public wind wind { get; set; }
            public sys sys {  get; set; }

        }
    }
}

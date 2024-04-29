using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using Grimstad_Weather_Application;

namespace Grimstad_Weather_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        string APIKey = "c22da37e96a4de0fa72ec2646d6694ec";

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getWeather();
            getForecast();
        }
       
        double lon;
        double lat;
        //private object FLP;

        //Current Weather Data - Free version
        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q=grimstad&appid=c22da37e96a4de0fa72ec2646d6694ec", TBCity.Text, APIKey);
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                picIcon.ImageLocation = "https://openweathermap.org/img/w/02d.png" + Info.Weather[0].icon;
                labCondition.Text = Info.Weather[0].main;
                labDetails.Text = Info.Weather[0].description;
                labSunset.Text = convertDateTime(Info.sys.sunset).ToShortTimeString();
                labSunrise.Text = convertDateTime(Info.sys.sunrise).ToShortTimeString();

                labWindSpeed.Text = Info.wind.speed.ToString();
                labPressure.Text = Info.main.pressure.ToString();

                lon = Info.coord.lon;
                lat = Info.coord.lat;
            }
        }
        DateTime convertDateTime(long sec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(sec);

            return day;
        }

        //Open-Meteo - Free version
        void getForecast()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/forecast?lat=58.2839967&lon=8.712829118742853&appid=c22da37e96a4de0fa72ec2646d6694ec", lat, lon, APIKey);
                var json = web.DownloadString(url);
                weatherForecast.forecastInfo forecastInfo = JsonConvert.DeserializeObject<weatherForecast.forecastInfo>(json);

                UserControl2 FUC;
                for(int i = 0; i < 30; i++)
                {
                    FUC = new UserControl2();
                    FUC.picWeatherIcon.ImageLocation = "https://openweathermap.org/img/w/" + forecastInfo.daily[i].weather[0] + ".png";
                    FUC.labMainWeather.Text = forecastInfo.daily[i].weather[0].description;
                    FUC.labDT.Text = convertDateTime(forecastInfo.daily[i].dt).DayOfWeek.ToString();

                    flowLayoutPanel1.Controls.Add(FUC);
                }
            }
        }
    }
}
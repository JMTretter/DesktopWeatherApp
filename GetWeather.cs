using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopWeatherApp
{
    class GetWeather
    {
        public static string apiKey = " ";
        
        public static List<List<string>> GetWeatherForcast(List<string> location)
        {
            string lat = location[0];
            string lon = location[1];

            //Call to API to get daily forecase using latitude and longitude that are passed in from form1
            var client = new RestClient("http://api.weatherbit.io/v2.0/forecast/daily?lat=" + lat + "&lon=" + lon + "&key=" + apiKey);

            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            string weather = response.Content;
            
            //Deserialize json response into C# object
            var weatherForecast = JsonConvert.DeserializeObject<ForecastData.Root>(weather);

            //List to hold a list that contains daily weather data
            List<List<string>> WeatherData = new List<List<string>>();

            //loop through and build each list and add daily list to WeatherData
            foreach (var wf in weatherForecast.data)
            {
                List<string> list = new List<string>();

                list.Add(wf.datetime.ToString());

                double feelsLikeHigh = ConvertToFahrenheit(wf.app_max_temp);
                list.Add(feelsLikeHigh.ToString());

                double feelsLikeLow = ConvertToFahrenheit(wf.app_min_temp);
                list.Add(feelsLikeLow.ToString());

                double lowTemp = ConvertToFahrenheit(wf.low_temp);
                list.Add(lowTemp.ToString());

                double highTemp = ConvertToFahrenheit(wf.high_temp);
                list.Add(highTemp.ToString());

                list.Add(wf.weather.description.ToString());

                WeatherData.Add(list); 
            }
            return WeatherData;
        }

        public static List<List<string>> GetHourlyForcast(List<string> location)
        {
            string lat = location[0];
            string lon = location[1];

            //API call to get users hourly forecast based on latitude and longitude
            var client = new RestClient("http://api.weatherbit.io/v2.0/forecast/hourly?lat=" + lat + "&lon=" + lon + "&key=" + apiKey);
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            string weather = response.Content;

            //deserialize json response into C# object
            var weatherForecast = JsonConvert.DeserializeObject<HourlyData.Root>(weather);

            //List to hold a list that contains hourly weather data
            List<List<string>> WeatherData = new List<List<string>>();

            //loop through and build each list and add hourly list to WeatherData
            foreach (var wf in weatherForecast.data)
            {
                List<string> list = new List<string>();

                list.Add(wf.timestamp_local.ToString());
                
                double feelsLikeHigh = ConvertToFahrenheit(wf.app_temp);
                list.Add(feelsLikeHigh.ToString());

                double highTemp = ConvertToFahrenheit(wf.temp);
                list.Add(highTemp.ToString());

                list.Add(wf.weather.description.ToString());

                WeatherData.Add(list);
            }
                return WeatherData;
        }

        public static double ConvertToFahrenheit(double x)
        {
            return (x * 9 / 5) + 32;
        }
    }
}

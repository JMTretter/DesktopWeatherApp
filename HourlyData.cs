using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopWeatherApp
{
    //Class to Hold hourly Forecast Json object
    class HourlyData
    {
        public class Weather
        {
            public string icon { get; set; }
            public int code { get; set; }
            public string description { get; set; }
        }

        public class Datum
        {
            public string wind_cdir { get; set; }
            public int rh { get; set; }
            public string pod { get; set; }
            public DateTime timestamp_utc { get; set; }
            public double pres { get; set; }
            public double solar_rad { get; set; }
            public double ozone { get; set; }
            public Weather weather { get; set; }
            public double wind_gust_spd { get; set; }
            public DateTime timestamp_local { get; set; }
            public int snow_depth { get; set; }
            public int clouds { get; set; }
            public int ts { get; set; }
            public double wind_spd { get; set; }
            public int pop { get; set; }
            public string wind_cdir_full { get; set; }
            public double slp { get; set; }
            public double dni { get; set; }
            public double dewpt { get; set; }
            public int snow { get; set; }
            public double uv { get; set; }
            public int wind_dir { get; set; }
            public int clouds_hi { get; set; }
            public double precip { get; set; }
            public double vis { get; set; }
            public double dhi { get; set; }
            public double app_temp { get; set; }
            public string datetime { get; set; }
            public double temp { get; set; }
            public double ghi { get; set; }
            public int clouds_mid { get; set; }
            public int clouds_low { get; set; }
        }

        [JsonObject]
        public class Root : IEnumerable<Root>
        {
            List<Root> roots = new List<Root>();
            public List<Datum> data { get; set; }
            public string city_name { get; set; }
            public double lon { get; set; }
            public string timezone { get; set; }
            public double lat { get; set; }
            public string country_code { get; set; }
            public string state_code { get; set; }

            public IEnumerator<Root> GetEnumerator()
            {
                return roots.GetEnumerator();
            }
            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

        }
    }
}

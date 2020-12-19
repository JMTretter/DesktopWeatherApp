using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopWeatherApp
{
    //Class to Hold Daily Forecast Json object 
    class ForecastData 
    {

        public class Weather
        {
            [JsonProperty("icon")]
            public string icon { get; set; }
            [JsonProperty("code")]
            public int code { get; set; }
            [JsonProperty("description")]
            public string description { get; set; }
        }

        public class Datum
        {
            [JsonProperty("moonrise_ts")]
            public int moonrise_ts { get; set; }
            [JsonProperty("wind_cdir")]
            public string wind_cdir { get; set; }
            [JsonProperty("rh")]
            public int rh { get; set; }
            [JsonProperty("pres")]
            public double pres { get; set; }
            [JsonProperty("high_temp")]
            public double high_temp { get; set; }
            [JsonProperty("sunset_ts")]
            public int sunset_ts { get; set; }
            [JsonProperty("ozone")]
            public double ozone { get; set; }
            [JsonProperty("moon_phase")]
            public double moon_phase { get; set; }
            [JsonProperty("wind_gust_spd")]
            public double wind_gust_spd { get; set; }
            [JsonProperty("snow_depth")]
            public double snow_depth { get; set; }
            [JsonProperty("clouds")]
            public int clouds { get; set; }
            [JsonProperty("ts")]
            public int ts { get; set; }
            [JsonProperty("sunrise_ts")]
            public int sunrise_ts { get; set; }
            [JsonProperty("app_min_temp")]
            public double app_min_temp { get; set; }
            [JsonProperty("wind_spd")]
            public double wind_spd { get; set; }
            [JsonProperty("pop")]
            public int pop { get; set; }
            [JsonProperty("wind_cdir_full")]
            public string wind_cdir_full { get; set; }
            [JsonProperty("slp")]
            public double slp { get; set; }
            [JsonProperty("moon_phase_lunation")]
            public double moon_phase_lunation { get; set; }
            [JsonProperty("valid_date")]
            public string valid_date { get; set; }
            [JsonProperty("app_max_temp")]
            public double app_max_temp { get; set; }
            [JsonProperty("vis")]
            public double vis { get; set; }
            [JsonProperty("dewpt")]
            public double dewpt { get; set; }
            [JsonProperty("snow")]
            public double snow { get; set; }
            [JsonProperty("uv")]
            public double uv { get; set; }
            [JsonProperty("weather")]
            public Weather weather { get; set; }
            [JsonProperty("wind_dir")]
            public int wind_dir { get; set; }
            [JsonProperty("max_dhi")]
            public object max_dhi { get; set; }
            [JsonProperty("clouds_hi")]
            public int clouds_hi { get; set; }
            [JsonProperty("precip")]
            public double precip { get; set; }
            [JsonProperty("low_temp")]
            public double low_temp { get; set; }
            [JsonProperty("max_temp")]
            public double max_temp { get; set; }
            [JsonProperty("moonset_ts")]
            public int moonset_ts { get; set; }
            [JsonProperty("datetime")]
            public string datetime { get; set; }
            [JsonProperty("temp")]
            public double temp { get; set; }
            [JsonProperty("min_temp")]
            public double min_temp { get; set; }
            [JsonProperty("clouds_mid")]
            public int clouds_mid { get; set; }
            [JsonProperty("clouds_low")]
            public int clouds_low { get; set; }
            
        }
        [JsonObject]
        public class Root : IEnumerable<Root>
        {
            List<Root> roots = new List<Root>();

            [JsonProperty("data")]
            public List<Datum> data { get; set; }
            [JsonProperty("city_name")]
            public string city_name { get; set; }
            [JsonProperty("lon")]
            public double lon { get; set; }
            [JsonProperty("timezone")]
            public string timezone { get; set; }
            [JsonProperty("lat")]
            public double lat { get; set; }
            [JsonProperty("country_code")]
            public string country_code { get; set; }
            [JsonProperty("state_code")]
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

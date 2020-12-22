using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DesktopWeatherApp
{

    class GetIPAddress
    {
        public static List<string> IPAddress()
        {
            //List that hold user's latitude and longitude
            List<string> loc = new List<string>();

            string ipApiKey = "";

            //string to store user's IP address
            string publicIPAddress = new WebClient().DownloadString("http://icanhazip.com");

            //Call to API to get latitude and longitude for user's IP address
            var client = new RestClient("http://api.ipstack.com/" + publicIPAddress + "?access_key=" + ipApiKey);
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            string jsonResponse = response.Content;

            //deserialize json object
            var location = JsonConvert.DeserializeObject<IPData.Root>(jsonResponse);

            //add latitude and longitude to list 
            loc.Add(location.latitude.ToString());
            loc.Add(location.longitude.ToString());

            //return list to form1
            return loc;
        }
    }
}


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace OMDBAPI.Models
{
    public class MovieDAL
    {
        public string CallAPI(string searchType, string title)
        {
            string key = "6f803922";
            string url = @$"https://www.omdbapi.com/?{searchType}={title}&apikey={key}";
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader rd = new StreamReader(response.GetResponseStream());
            string output = rd.ReadToEnd();
            return output;
        }
        public Movie GetMovie(string title)
        {
            string json = CallAPI("t", title);
            Movie m = JsonConvert.DeserializeObject<Movie>(json);
            return m;

        }
    }
}

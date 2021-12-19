using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Data;
using Newtonsoft.Json;

namespace MyMVCApplication.Controllers
{
    
     
    public class TemperaturesController : Controller
    {
        // GET: Mvc2Test
        [Route("Mvctestp")]
        public ActionResult MyIndexp(int? id)
        {
            return View();
        }


       
        [ActionName("MyIndex")] 
        public ActionResult MyIndex()//http://localhost:47005/Temperatures/MyIndex
        {
            string sUrl = "http://api.openweathermap.org/data/2.5/forecast?lat=25.0853&lon=28.1111&appid=4ce97563e2ccf5dc64513ebb6aba9faa&units=metric";
             
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync(sUrl).Result;
            string ret = response.Content.ReadAsStringAsync().Result;
            
            var jObject = Newtonsoft.Json.Linq.JObject.Parse(ret);
            
            var postTitles =
            from p in jObject["list"]
            select (string)p["main"]["temp"];

            foreach (var item in postTitles)
            {
                Console.WriteLine(item);
            }
            var postTitles2 =
            from p in jObject["list"]
            select new { temp=(string)p["main"]["temp"],dt_txt= (string)p["dt_txt"] };
            foreach (var item in postTitles2)
            {
                Console.WriteLine(item);
            }
            var data = postTitles2.Select(x =>
                new Models.Temperatures
                {
                    DayTime = DateTime.Parse( x.dt_txt).ToString("yyyy-MM-dd HH:mm"),
                    Degrees =float.Parse ( x.temp)
                });

            var list = data.ToList<Models.Temperatures>();
            return View(list);//to see the default table
            
        }

        //***********
        [ActionName("GetTAShort")]
        public string GetTAShort()//http://localhost:47005/Temperatures/MyIndex
        {
            

            string sUrl = "http://api.openweathermap.org/data/2.5/forecast?lat=25.0853&lon=28.1111&appid=4ce97563e2ccf5dc64513ebb6aba9faa&units=metric";
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync(sUrl).Result;
            string ret = response.Content.ReadAsStringAsync().Result;

            var jObject = Newtonsoft.Json.Linq.JObject.Parse(ret);

            var postTitles =
            from p in jObject["list"]
            select (string)p["main"]["temp"];

            foreach (var item in postTitles)
            {
                Console.WriteLine(item);
            }
            var postTitles2 =
            from p in jObject["list"]
            select new { temp = (string)p["main"]["temp"], dt_txt = (string)p["dt_txt"] };
            foreach (var item in postTitles2)
            {
                Console.WriteLine(item);
            }
            var data = postTitles2.Select(x =>
                new Models.Temperatures
                {
                    DayTime = DateTime.Parse( x.dt_txt).ToString("yyyy-MM-dd H:mm:ss"),
                    Degrees =float.Parse( x.temp)
                });

            var list = data.ToList<Models.Temperatures>();
            string tmp = JsonConvert.SerializeObject(list);
            return tmp;
            
            
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace OnlineTest.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Result = "0";
            return View();
        }


        [HttpPost]
        public void SearchNumber(FormCollection form)
        {
            int divisor = 0;
            int number = 0;
            int seriesLength = 0;
            int.TryParse(form["Divisor"], out divisor);
            int.TryParse(form["Number"], out number);
            int.TryParse(form["SeriesLength"], out seriesLength);
            string url = "http://localhost:60557/api/Series?divisor=" + divisor + "&number=" + number + "&seriesLength=" + seriesLength;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);
            var responseTask = client.GetAsync(url);
            responseTask.Wait();
            var res = responseTask.Result;
            if (res.IsSuccessStatusCode)
            {
                ViewBag.Result = res.ToString();
            }
        }
    }
}
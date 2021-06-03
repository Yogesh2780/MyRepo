using OnlineTest.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OnlineTest.Controllers
{
    public class SeriesController : ApiController
    {
       [Route("api/Series/{maxLength}")]
       public List<int> GetSeries(int maxLength)
        {
            if(maxLength == 0)
            {
                return null;
            }

            return SeriesManager.GenerateSeries(maxLength);
        }

        [HttpGet]
        [Route("api/SearchSeries")]
        public int SearchSeries([FromUri] int divisor, [FromUri] int number, [FromUri] int seriesLength = 15)
        {
            return SeriesManager.Search(divisor, number, seriesLength);
        }

    }
}

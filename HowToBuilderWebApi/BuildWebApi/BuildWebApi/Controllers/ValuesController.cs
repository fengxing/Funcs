using System;
using System.Web.Http;

namespace BuildWebApi.Controllers
{
    public class ValuesController : ApiController
    {
        [HttpGet]
        [Route("Values/Get")]
        public string Get()
        {
            return DateTime.Now.Ticks.ToString();
        }
    }
}

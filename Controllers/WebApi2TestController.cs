using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyMVCApplication.Controllers
{
    public class WebApi2TestController : ApiController
    {
        // GET: api/WebApi2Test/5        
         
        public string Get()//no url brought me in here
        {
            return "value";
        }

        // GET: api/WebApi2Test i remarked tempo
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //works fine the following call!!!!
        //[HttpGet]
        //[Route("myget")]
        //public string myget(int id)
        //{
        //    return "value";
        //}

        // POST: api/WebApi2Test
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/WebApi2Test/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/WebApi2Test/5
        //public void Delete(int id)
        //{
        //}
    }
}

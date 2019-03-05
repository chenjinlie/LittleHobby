using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Littlehobby.Controllers
{
    [Produces("application/json")]
    [Route("api/Content")]
    public class ContentController : Controller
    {
        // GET: api/Content
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Content/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "xxxx";
        }
        
        // POST: api/Content
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Content/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }




    }
}

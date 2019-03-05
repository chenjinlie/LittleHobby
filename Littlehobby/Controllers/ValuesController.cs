using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataSimulator;
using System.Data;

namespace Littlehobby.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            string cef= string.Empty;
            //定义接口列表，1.请求首页文章以及背景图片地址等等
            //2.三个页面分别请求的值为，1（Music）2(Mover)3(Code)
            if (id == 2)
            {
                DataTable dt = new DataTable();
                string sql = "SELECT ArticleDescription FROM [dbo].[Information] where Type=2;";
                dt= DbHelperSQL.Query(sql).Tables[0];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cef = cef+dt.Rows[i]["ArticleDescription"].ToString();
                }
            }

            return cef;

        }
        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return "text";
        }
    }
}

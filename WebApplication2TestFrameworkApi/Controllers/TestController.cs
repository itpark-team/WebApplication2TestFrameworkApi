using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2TestFrameworkApi.db;
using WebApplication2TestFrameworkApi.Models;

namespace WebApplication2TestFrameworkApi.Controllers
{
    public class TestController : ApiController
    {
        // GET: api/Test
        /*public List<PostData> Get()
        {
            return PostDatasRepository.postDatas;
        }*/

        public List<Unit> Get()
        {
            Heroes3Entities db = new Heroes3Entities();

            return db.Units.ToList();
        }

        // GET: api/Test/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Test
        public void Post([FromBody]PostData postData)
        {
            PostDatasRepository.postDatas.Add(postData);
        }

        // PUT: api/Test/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Test/5
        public void Delete(int id)
        {
        }
    }
}

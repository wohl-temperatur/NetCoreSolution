﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Net;
using Newtonsoft.Json;

namespace NetCoreApplication.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            return Startup.Configuration["ASPNETCORE_ENVIRONMENT"];
        }
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        // POST api/values
        [HttpPost]
        public JsonResult Post([FromBody]JObject param)
        {
            string s = null;
            JsonResult result = new JsonResult(new { a = "aaa2", b = "bbb", n = s });
            result.StatusCode = (int)HttpStatusCode.OK;
            result.SerializerSettings = new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore };
            return result;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

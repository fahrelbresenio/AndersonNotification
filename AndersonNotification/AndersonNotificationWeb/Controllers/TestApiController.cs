﻿using System;
using System.Web.Http;

namespace AndersonNotificationWeb.ApiControllers
{
    [RoutePrefix("TestApi")]
    public class TestApiController : BaseApiController
    {
        [Route("Get")]
        public IHttpActionResult Get()
        {
            return Ok(new string[] { "value1", "value2" });
        }
        public string Get (int Id)
        {
            return "value";
        }
        public void Post ([FromBody]string value)
        {
        }
        public void Put (int Id,[FromBody]string value)
        {
        }
        public void Delete(int Id)
        {

        }
    }
}
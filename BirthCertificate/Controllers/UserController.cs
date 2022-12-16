using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BirthCertificate.Controllers
{
    public class UserController : ApiController
    {
        [Route("api/Users")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = UserService.Get(default);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/User/{id}")]

        public HttpResponseMessage Get(int id)
        {
            var data = UserService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

   
   


    }


}



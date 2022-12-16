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
    public class VolunteerController : ApiController
    {
        [Route("api/volunteer")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = VolenteerService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/volunteer/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = VolenteerService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/volunteer/add")]
        [HttpPost]
        public HttpResponseMessage Post(VolenteerDTO volenteer)
        {
            if (ModelState.IsValid)
            {
                var resp = VolenteerService.Add(volenteer);
                if (resp != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Inserted", data = volenteer });
                }
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
    }
}

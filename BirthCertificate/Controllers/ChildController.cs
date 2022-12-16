using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace BirthCertificate.Controllers
{
    public class ChildController : ApiController
    {

        [Route("api/children")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = ChildService.Get(default);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/children/{id}")]

        public HttpResponseMessage Get(int id)
        {
            var data = ChildService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("Hospitalserviecs/delete")]

        [HttpPost]
        public HttpResponseMessage Create(HospitalDTO hospital)
        {
            var isCreated = HospitalService.Delete(hospital);

            return Request.CreateResponse(HttpStatusCode.OK, hospital);
        }





    }
}

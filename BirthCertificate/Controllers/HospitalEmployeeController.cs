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
    public class HospitalEmployeeController : ApiController
    {
        [Route("api/hospitalemployee")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = HospitalEmployeeService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/hospitalemployee/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = HospitalEmployeeService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/hospitalemployee/add")]
        [HttpPost]  
        public HttpResponseMessage Add(HospitalEmployeeDTO hospitalEmployee)
        {
            if (ModelState.IsValid)
            {
                var data = HospitalEmployeeService.Add(hospitalEmployee);
                if (data == null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }
    }
}

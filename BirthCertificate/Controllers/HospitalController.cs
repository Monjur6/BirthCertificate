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
    public class HospitalController : ApiController
    {
        [Route("api/Hospital/home")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var d = HospitalService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, d);
        }

        [Route("api/Hospital/home/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var d = HospitalService.Get(id);
            ////if (d != null)
            return Request.CreateResponse(HttpStatusCode.OK, d);
            // else
            // return Request.CreateResponse(HttpStatusCode.NotFound, "Empty");
        }
        //[Route("api/client/update")]
        //[HttpGet]
        //public HttpResponseMessage Update(HospitalDTO Hospital)
        //{
        //    if (HospitalService.e
        //    {
        //        return Request.CreateResponse(HttpStatusCode.OK, "Profile Edited Successfully");
        //    }
        //    return Request.CreateResponse(HttpStatusCode.NotFound, "Profile Edit Failed");
        //}


        [Route("api/Hospitals/add")]
        [HttpPost]
        public HttpResponseMessage Add(HospitalDTO hospital)
        {
            var data = HospitalService.Add(hospital);
            if (data != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.InternalServerError);

        }


        [Route("Hospitalserviecs/create")]

        [HttpPost]
        public HttpResponseMessage Create(HospitalDTO hospital)
        {
            var isCreated = HospitalService.Add(hospital);

            return Request.CreateResponse(HttpStatusCode.OK, hospital);
        }

        [Route("categoryinvoices/delete/{id}")]
        [HttpPost]
        public HttpResponseMessage Delete(int hospital)
        {
            var isDeleted = HospitalService.Delete(hospital);

            return Request.CreateResponse(HttpStatusCode.OK, hospital);


        }
        [Route("categoryinvoices/update")]

        [HttpPost]
        public HttpResponseMessage Update(HospitalDTO hospital)
        {
            var isUpdated = HospitalService.Update(hospital);

            return Request.CreateResponse(HttpStatusCode.OK, hospital);


        }

    }
}


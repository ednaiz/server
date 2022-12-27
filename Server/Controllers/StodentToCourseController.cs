using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Server.Controllers
{
    public class StodentToCourseController : ApiController
    {
        public IHttpActionResult Post(List<StudentToCourseDTO> marks)
        {
            BLL.service.StudentToCourseService.Post(marks);
            return Ok();
        }
        public IHttpActionResult Get(List<StudentToCourseDTO> marks)
        {
            BLL.service.StudentToCourseService.Post(marks);
            return Ok();
        }
    }
}

using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Server.Controllers
{
    public class AttendancyController : ApiController
    {
        [Route("~/api/Attendancy/enter")]
        public IHttpActionResult Post( AttendancyDTO attendancy)
        {
            BLL.AttendancyService.Post(attendancy);
            return Ok();
        }
        [Route("~/api/Attendancy/Exit")]
        public IHttpActionResult Post(AttendancyExitDTO attendancy)
        {
            BLL.AttendancyService.Post(attendancy);
            return Ok();
        }
        [Route("~/api/Attendancy/Active")]
        public IHttpActionResult Post(List< AttendancyActiveDTO> attendancy)
        {
            BLL.AttendancyService.Post(attendancy);
            return Ok();
        }
    }
}

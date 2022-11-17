using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DTO
{
    public class AttendancyDTO
    {
        public string Id { get; set; }
        public string Enter { get; set; }
        public string Exit { get; set; }
        public string Date { get; set; }
        public string UserId { get; set; }
        public string CourseId { get; set; }
        public bool Active { get; set; }
    }
    public class AttendancyActiveDTO
    {
        public string Id { get; set; }
        public bool Active { get; set; }

    }
    public class AttendancyExitDTO
    {
        public string Exit { get; set; }
        public string Date { get; set; }
        public string UserId { get; set; }
        public string CourseId { get; set; }

    }
}

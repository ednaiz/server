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
        public int Id { get; set; }
        public System.TimeSpan EnterTime { get; set; }
        public Nullable<System.TimeSpan> ExitTime { get; set; }
        public System.DateTime Date { get; set; }
        public int UserId { get; set; }
        public Nullable<int> LessonId { get; set; }
        public Nullable<bool> Active { get; set; }
    }
    public class AttendancyActiveDTO
    {
        public int Id { get; set; }
        public bool Active { get; set; }

    }
    public class AttendancyExitDTO
    {
        public TimeSpan ExitTime { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public int LessonId { get; set; }

    }
}

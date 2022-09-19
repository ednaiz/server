using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     public class Attendency
    {
        public int Id { get; set; }
        public DateTime Exit { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public int CourseId { get; set; }
    }
}

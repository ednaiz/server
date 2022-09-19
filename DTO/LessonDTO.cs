using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LessonDTO
    {
        public int id { get; set; }
        public DateTime Date { get; set; }
        public string Start { get; set; }
        public string Finish { get; set; }
    }
}

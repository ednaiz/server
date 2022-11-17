using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL.convertion
{
    public class AttendancyConversion
    {
        public static AttendancyDTO Convert(DAL.Attendancy obj)
        {
            if (obj == null)
                return null;
            return new AttendancyDTO()
            {
                Id = obj.Id
            };
        }
        public static Attendancy Convert(AttendancyDTO obj)
        {
            if (obj == null)
                return null;
            return new Attendancy()
            {
                Id = obj.Id
            };
        }
        public static List<Attendancy> Convert(List<AttendancyDTO> user)
        {
            return user.Select(x => Convert(x)).ToList();
        }
        public static List<AttendancyDTO> Convert(List<Attendancy> user)
        {
            return user.Select(x => Convert(x)).ToList();
        }
    }
}


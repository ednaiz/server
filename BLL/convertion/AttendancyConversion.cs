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
        public static AttendancyDTO Covert(Attendancy obj)
        {
            if (obj == null)
                return null;
            return new AttendancyDTO()
            {
                Id = obj.Id
            };
        }
        public static Attendancy Covert(AttendancyDTO obj)
        {
            if (obj == null)
                return null;
            return new Attendancy()
            {
                Id = obj.Id
            };
        }
        public static List<Attendancy> Covert(List<AttendancyDTO> user)
        {
            return user.Select(x => Covert(x)).ToList();
        }
        public static List<AttendancyDTO> Covert(List<Attendancy> user)
        {
            return user.Select(x => Covert(x)).ToList();
        }
    }
}

    }
}

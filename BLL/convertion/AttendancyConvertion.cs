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
        public static AttendancyDTO Convert(DAL.attendancy obj)
        {
            if (obj == null)
                return null;
            return new AttendancyDTO()
            {
                Id = obj.Id,
                Active=obj.Active,
                Date=obj.Date,
                EnterTime=obj.EnterTime,
                ExitTime=obj.ExitTime,
                LessonId=obj.LessonId,
                UserId=obj.UserId
            };
        }
        public static attendancy Convert(AttendancyExitDTO obj)
        {
            if (obj == null)
                return null;
            return new attendancy()
            {
                Date = obj.Date,
                ExitTime = obj.ExitTime,
                LessonId = obj.LessonId,
                UserId = obj.UserId


            };
        }
        public static attendancy Convert(AttendancyActiveDTO obj)
        {
            if (obj == null)
                return null;
            return new attendancy()
            {
                Id = obj.Id,
               // Active=obj.Active      
            };
        }
        public static attendancy Convert(AttendancyDTO obj)
        {
            if (obj == null)
                return null;
            return new attendancy()
            {
                Id = obj.Id,
                Active = obj.Active,
                Date = obj.Date,
                EnterTime = obj.EnterTime,
                ExitTime = obj.ExitTime,
                LessonId = obj.LessonId,
                UserId = obj.UserId
            };
        }
        public static List<attendancy> Convert(List<AttendancyActiveDTO> user)
        {
            return user.Select(x => Convert(x)).ToList();
        }
        public static List<attendancy> Convert(List<AttendancyDTO> user)
        {
            return user.Select(x => Convert(x)).ToList();
        }
        public static List<AttendancyDTO> Convert(List<attendancy> user)
        {
            return user.Select(x => Convert(x)).ToList();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
   public class AttendancyService
    {
      public static List<AttendancyDTO> get()
        {
            return convertion.AttendancyConversion.Convert(new DAL.model.AttendancyModel().Get());
        }
        public static AttendancyDTO get(string id)
        {
            return convertion.AttendancyConversion.Convert(new DAL.model.AttendancyModel().Get(id));
        }

        public static AttendancyDTO get(string Exit,string Enter,string Date, string UserId, string CourseId)//change properties
        {
            return convertion.AttendancyConversion.Convert(new DAL.model.AttendancyModel().Get( Exit,Enter, Date,  UserId,  CourseId));
        }
        public static AttendancyDTO Post(AttendancyDTO Attendancy)
        {
            return convertion.AttendancyConversion.Convert(new DAL.model.AttendancyModel().Post(convertion.AttendancyConversion.Convert(Attendancy)));
        }
        public static AttendancyDTO Put(AttendancyDTO Attendancy)
        {
            return convertion.AttendancyConversion.Convert(new DAL.model.AttendancyModel().Put(convertion.AttendancyConversion.Convert(Attendancy)));
        }
    }
}
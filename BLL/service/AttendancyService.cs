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
        public static AttendancyDTO get(int id)
        {
            return convertion.AttendancyConversion.Convert(new DAL.model.AttendancyModel().Get(id));
        }

        public static AttendancyDTO get(TimeSpan Exit,TimeSpan Enter,DateTime Date, int UserId, int CourseId)//change properties
        {
            return convertion.AttendancyConversion.Convert(new DAL.model.AttendancyModel().Get( Exit,Enter, Date,  UserId,  CourseId));
        }
        public static AttendancyDTO Post(AttendancyDTO Attendancy)
        {
            return convertion.AttendancyConversion.Convert(new DAL.model.AttendancyModel().Post(convertion.AttendancyConversion.Convert(Attendancy)));
        }
        public static AttendancyDTO Post(AttendancyExitDTO Attendancy)
        {
            return convertion.AttendancyConversion.Convert(new DAL.model.AttendancyModel().PostExit(convertion.AttendancyConversion.Convert(Attendancy)));

        }
        public static AttendancyDTO Post(AttendancyActiveDTO Attendancy)
        {
            return convertion.AttendancyConversion.Convert(new DAL.model.AttendancyModel().PostExit(convertion.AttendancyConversion.Convert(Attendancy)));

        }
        public static AttendancyDTO Put(AttendancyDTO Attendancy)
        {
            return convertion.AttendancyConversion.Convert(new DAL.model.AttendancyModel().Put(convertion.AttendancyConversion.Convert(Attendancy)));
        }
    }
}
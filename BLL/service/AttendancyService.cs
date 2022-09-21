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
            return convertion.AttendancyService.Covert(new DAL.model.AttendancyModel().Get());
        }
        public static AttendancyDTO get(int id)
        {
            return convertion.AttendancyConversion.Covert(new DAL.model.AttendancyModel().Get(id));
        }

        public static AttendancyDTO get(DateTime Exit,DateTime Enter,DateTime Date, int UserId, int CourseId)//change properties
        {
            return convertion.AttendancyCovertion.Covert(new DAL.model.AttendancyModel().Get( Exit,Enter, Date,  UserId,  CourseId));
        }
        public static AttendancyDTO Post(AttendancyDTO Attendancy)
        {
            return convertion.AttendancyConversion.Covert(new DAL.model.AttendancyModel().Post(convertion.AttendancyConversion.Covert(Attendancy)));
        }
        public static AttendancyDTO Put(AttendancyDTO Attendancy)
        {
            return convertion.UserCovertion.Covert(new DAL.model.UserModel().Put(convertion.UserCovertion.Covert(Attendancy)));
        }
    }
}
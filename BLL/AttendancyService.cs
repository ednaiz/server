using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class AttendancyService
    {
      public static List<AttendancyDTO> get()
        {
            return convertion.userCovertion.Covert(new DAL.model.userModel().Get());
        }public static AttendancyDTO get(int id)
        {
            return convertion.userCovertion.Covert(new DAL.model.userModel().Get(id));
        }

        public static AttendancyDTO get(DateTime Exit,DateTime Date, int UserId, int CourseId)//change properties
        {
            return convertion.userCovertion.Covert(new DAL.model.userModel().Get( Exit, Date,  UserId,  CourseId));
        }
        public static AttendancyDTO Post(AttendancyDTO Attendancy)
        {
            return convertion.userCovertion.Covert(new DAL.model.userModel().Post(convertion.userCovertion.Covert(Attendancy)));
        }
        public static AttendancyDTO Put(AttendancyDTO Attendancy)
        {
            return convertion.userCovertion.Covert(new DAL.model.userModel().Put(convertion.userCovertion.Covert(Attendancy)));
        }
        public static AttendancyDTO Delete(AttendancyDTO Attendancy)
        {
            return convertion.userCovertion.Covert(new DAL.model.userModel().Delete(convertion.userCovertion.Covert(Attendancy)));
        }
    }
}
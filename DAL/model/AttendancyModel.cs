using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.model
{
    public class AttendancyModel
    {
        public List<Attendancy> Get()
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                return db.Attendancy.ToList();
            }
        }
        public Attendancy Get(string Exit,string Enter, string Date, string UserId, string CourseId)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                return db.Attendancy.FirstOrDefault(x => x.UserId == UserId && Exit == x.Exit &&x.Enter==Enter&& x.Date == Date && x.CourseId == CourseId);

            }
        }
        public Attendancy Get(string Id)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                return db.Attendancy.FirstOrDefault(x => x.Id == Id);
            }

        }
        public Attendancy Post(Attendancy Attendancy)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                Attendancy = db.Attendancy.Add(Attendancy);
                db.SaveChanges();
                return Attendancy;
            }
        }
        public Attendancy Put(Attendancy Attendancy)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                Attendancy findAttendancy = db.Attendancy.FirstOrDefault(x => x.Id == Attendancy.Id);
                findAttendancy.CourseId = Attendancy.CourseId;
                findAttendancy.Exit = Attendancy.Exit;
                findAttendancy.Enter = Attendancy.Enter;
                findAttendancy.Date = Attendancy.Date;
                findAttendancy.UserId = Attendancy.UserId;
                db.SaveChanges();
                return findAttendancy;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.model
{
    public class AttendancyModel
    {
        public List<attendancy> Get()
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                return db.attendancy.ToList();
            }
        }
        public attendancy Get(TimeSpan Exit,TimeSpan Enter, DateTime Date, int UserId, int LessonId)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                return db.attendancy.FirstOrDefault(x => x.UserId == UserId && Exit == x.ExitTime &&x.EnterTime==Enter&& x.Date == Date && x.LessonId == LessonId);

            }
        }
        public attendancy Get(int Id)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                return db.attendancy.FirstOrDefault(x => x.Id == Id);
            }

        }
        public attendancy Post(attendancy Attendancy)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                Attendancy = db.attendancy.Add(Attendancy);
                db.SaveChanges();
                return Attendancy;
            }
        }
        public attendancy PostExit(attendancy Attendancy)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                attendancy ad= db.attendancy.FirstOrDefault(x => x.UserId == Attendancy.UserId && x.Date == Attendancy.Date);

                if (ad == null)
                {
                    return null;

                }
                ad.ExitTime = Attendancy.ExitTime;
                db.SaveChanges();
                return Attendancy;
            }
        }
        public void Post(List< attendancy> Attendancies)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                Attendancies.ForEach(Attendancy =>
                {
                    attendancy ad = db.attendancy.FirstOrDefault(x => x.UserId == Attendancy.UserId && x.Date == Attendancy.Date);

                    if (ad != null)
                    {
                      
                    //ad.Exit = Attendancy.;
                    }
                    
                });
                db.SaveChanges();
                
            }
        }
        public attendancy Put(attendancy Attendancy)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                attendancy findAttendancy = db.attendancy.FirstOrDefault(x => x.Id == Attendancy.Id);
                findAttendancy.LessonId = Attendancy.LessonId;
                findAttendancy.ExitTime = Attendancy.ExitTime;
                findAttendancy.EnterTime = Attendancy.EnterTime;
                findAttendancy.Date = Attendancy.Date;
                findAttendancy.UserId = Attendancy.UserId;
                db.SaveChanges();
                return findAttendancy;
            }
        }
    }
}

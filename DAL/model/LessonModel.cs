using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.model
{
    public class LessonModel
    {
        public List<lesson> Get()
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                return db.lesson.ToList();
            }
        }
        public lesson Get(TimeSpan Start, TimeSpan Finish, DateTime Date)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                return db.lesson.FirstOrDefault(x => x.StartTime == Start && Finish == x.EndTime && x.Date == Date);
            }
        }
        public lesson Get(int id)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                return db.lesson.FirstOrDefault(x => x.Id == id);
            }
        }
        public lesson Post(lesson lesson)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                lesson = db.lesson.Add(lesson);
                db.SaveChanges();
                return lesson;
            }
        }
        public lesson Put(lesson lesson)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {

                lesson findLesson = db.lesson.FirstOrDefault(x => x.Id == lesson.Id);
                findLesson.Date = lesson.Date;
                findLesson.StartTime = lesson.StartTime;
                findLesson.EndTime = lesson.EndTime;
                db.SaveChanges();
                return findLesson;
            }
        }
    }
}

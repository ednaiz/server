using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.model
{
    public class LessonModel
    {
        public List<Lesson> Get(DateTime date, string start)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                return db.Lesson.ToList();
            }
        }
        public Lesson Get(string Start, string Finish, DateTime Date)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                return db.Lesson.FirstOrDefault(x => x.Start == Start && Finish == x.Finish && x.Date == Date);
            }
        }
        public Lesson Get(int id)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                return db.Lesson.FirstOrDefault(x => x.Id == id);
            }
        }
        public Lesson Post(Lesson Lesson)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                Lesson = db.Lesson.Add(Lesson);
                db.SaveChanges();
                return Lesson;
            }
        }
        public Lesson Put(Lesson Lesson)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {

                Lesson findLesson = db.Lesson.FirstOrDefault(x => x.Id == Lesson.Id);
                findLesson.date = Lesson.date;
                findLesson.start = Lesson.start;
                findLesson.finish = Lesson.finish;
                db.SaveChanges();
                return findLesson;
            }
        }
    }
}

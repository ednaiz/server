using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.model
{
    public class LessonToCourseModel
    {
        public List<LessonToCourse> Get()
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                return db.LessonToCourse.ToList();
            }
        }

        public LessonToCourse Get(int id)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                return db.LessonToCourse.FirstOrDefault(x => x.Id == id);
            }
        }
        public LessonToCourse Get(int CourseId, int LessonId)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                return db.LessonToCourse.FirstOrDefault(x => x.CourseId == CourseId && x.LessonId == LessonId);
            }
        }

        public LessonToCourse Post(LessonToCourse LessonToCourse)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                db.LessonToCourse.Add(LessonToCourse);
                db.SaveChanges();
                return LessonToCourse;
            }
        }
        public LessonToCourse Put(LessonToCourse LessonToCourse)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {

                LessonToCourse findLessonToCourse = db.LessonToCourse.FirstOrDefault(x => x.Id == LessonToCourse.Id);
                findLessonToCourse.CourseId = LessonToCourse.CourseId;
                findLessonToCourse.LessonId = LessonToCourse.LessonId;
                db.SaveChanges();
                return findLessonToCourse;
            }
        }

    }
}

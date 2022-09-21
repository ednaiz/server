using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.model
{
   public class CourseModel
    {
        public List<Course> Get()
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                return db.Course.ToList();
            }
        }
        public Course Get(string Name, int UserId, int NumOfLessons)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                return db.Course.FirstOrDefault(x => x.Name == Name&&x.UserId==UserId&&NumOfLessons==x.NumOfLessons);
            }
        }
        public Course Get(int id)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                return db.Course.FirstOrDefault(x => x.Id == id);
            }
        }

        

        public Course Post(Course Course)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                Course= db.Course.Add(Course);
                db.SaveChanges();
                return Course;
            }
        }

        public Course Put(Course Course)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {

                Course findCourse = db.Course.FirstOrDefault(x => x.Id == Course.Id);
                findCourse.LessonToCourse = Course.LessonToCourse;
                findCourse.Name = Course.Name;
                findCourse.NumOfLessons = Course.NumOfLessons;
                findCourse.UserId = Course.UserId;
                db.SaveChanges();
                return findCourse;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.model
{
   public class CourseModel
    {
        public List<course> Get()
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                return db.course.ToList();
            }
        }
       
        public course Get(int id)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                return db.course.FirstOrDefault(x => x.Id == id);
            }
        }

        

        public course Post(course course)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                course= db.course.Add(course);
                db.SaveChanges();
                return course;
            }
        }

        public course Put(course course)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                course findCourse = db.course.FirstOrDefault(x => x.Id == course.Id);
                findCourse.Name = course.Name;
                findCourse.TeacherId = course.TeacherId;
                db.SaveChanges();
                return findCourse;
            }
        }
    }
}

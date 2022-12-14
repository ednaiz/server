using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.model
{
    public class StudentToCourseModel
    {
        public List<student_to_course> Get()
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                return db.student_to_course.ToList();
            }
        }

        public student_to_course Get(int id)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                return db.student_to_course.FirstOrDefault(x => x.Id == id);
            }
        }
        public student_to_course Get(int CourseId, int LessonId)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                return db.student_to_course.FirstOrDefault(x => x.CourseId == CourseId && x.CourseId == LessonId);
            }
        }

        public void Post(List< student_to_course> student_to_course)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                db.student_to_course.AddRange(student_to_course);
                db.SaveChanges();
                
            }
        }
        public student_to_course Put(student_to_course student_to_course)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {

                student_to_course findStudentToCourse = db.student_to_course.FirstOrDefault(x => x.Id == student_to_course.Id);
                findStudentToCourse.CourseId = student_to_course.CourseId;
                findStudentToCourse.UserId = student_to_course.UserId;
                db.SaveChanges();
                return findStudentToCourse;
            }
        }
    }
}

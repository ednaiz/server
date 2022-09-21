using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.model
{
    public class StudentToCourseModel
    {
        public List<StudentToCourse> Get()
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                return db.StudentToCourse.ToList();
            }
        }

        public StudentToCourse Get(int id)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                return db.StudentToCourse.FirstOrDefault(x => x.Id == id);
            }
        }
        public StudentToCourse Get(int CourseId, int LessonId)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                return db.StudentToCourse.FirstOrDefault(x => x.CourseId == CourseId && x.LessonId == LessonId);
            }
        }

        public StudentToCourse Post(StudentToCourse StudentToCourse)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                db.StudentToCourse.Add(StudentToCourse);
                db.SaveChanges();
                return StudentToCourse;
            }
        }
        public StudentToCourse Put(StudentToCourse StudentToCourse)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {

                StudentToCourse findStudentToCourse = db.StudentToCourse.FirstOrDefault(x => x.Id == StudentToCourse.Id);
                findStudentToCourse.CourseId = StudentToCourse.CourseId;
                findStudentToCourse.UserId = StudentToCourse.UserId;
                db.SaveChanges();
                return findStudentToCourse;
            }
        }
    }
}

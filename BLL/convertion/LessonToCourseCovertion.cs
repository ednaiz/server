using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.convertion
{
    public class LessonToCourseCovertion
    {
        public static LessonToCourseDTO Convert(LessonToCourse Lesson)
        {
            if (Lesson == null)
                return null;
            return new LessonToCourseDTO()
            {
                CourseId = Lesson.CourseId,
                LessonId = Lesson.LessonId
            };

        }

        public static List<LessonToCourseDTO> Convert(List<LessonToCourse> Lesson)
        {
            return Lesson.Select(x => Convert(x)).ToList();
        }
        public static List<LessonToCourse> Convert(List<LessonToCourseDTO> Lesson)
        {
            return Lesson.Select(x => Convert(x)).ToList();
        }
        public static LessonToCourse Convert(LessonToCourseDTO Lesson)
        {
            if (Lesson == null)
                return null;
            return new LessonToCourse()
            {
                CourseId = Lesson.CourseId,
                LessonId = Lesson.LessonId,
                Id = Lesson.Id
            };
        }
    }
}

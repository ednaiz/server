using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.convertion
{
     public class LessonToCourseCovertion
    {
        public static LessonToCourseDTO Covert(LessonToCourse Lesson)
        {
            if (Lesson == null)
                return null;
            return new LessonToCourseDTO()
            { CourseId = Lesson.CourseId, LessonId = Lesson.LessonId };

        }
    }
    public static List<LessonToCourseDTO> Covert(List<LessonToCourse> Lesson)
    {
        return Lesson.Select(x => Covert(x)).ToList();
    }
    public static List<LessonToCourse> Covert(List<LessonToCourseDTO> Lesson)
    {
        return Lesson.Select(x => Covert(x)).ToList();
    }
    public static LessonToCourse Convert(LessonToCourseDTO Lesson)
    {
        if (Lesson == null)
            return null;
        return new LessonToCourse()
        {
            CourseId = Lesson.CourseId,
            LessonId = Lesson.LessonId
        };
    }
}

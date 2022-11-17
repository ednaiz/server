using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL.service
{
    public class LessonToCourseService
    {
        public static List<LessonToCourseDTO> get()
        {
            return convertion.LessonToCourseCovertion.Convert(new DAL.model.LessonToCourseModel().Get());
        }
        public static LessonToCourseDTO get(int id)
        {
            return convertion.LessonToCourseCovertion.Convert(new DAL.model.LessonToCourseModel().Get(id));
        }
        public static LessonToCourseDTO get(int CourseId, int LessonId)
        {
            return convertion.LessonToCourseCovertion.Convert(new DAL.model.LessonToCourseModel().Get(CourseId, LessonId));
        }

        public static LessonToCourseDTO Post(LessonToCourseDTO lessonToCourse)
        {
            return convertion.LessonToCourseCovertion.Convert(new DAL.model.LessonToCourseModel().Post(convertion.LessonToCourseCovertion.Convert(lessonToCourse)));
        }
        public static LessonToCourseDTO Put(LessonToCourseDTO lessonToCourse)
        {
            return convertion.LessonToCourseCovertion.Convert(new DAL.model.LessonToCourseModel().Put(convertion.LessonToCourseCovertion.Convert(lessonToCourse)));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL.convertion
{
    public class StudentToCourseCovertion
    {
        public static StudentToCourseDTO Covert(StudentToCourse student)
        {
            if (student == null)
                return null;
            return new StudentToCourseDTO()
            { CourseId = student.CourseId, UserId = student.UserId };

        }
    }
    public static List<StudentToCourseDTO> Covert(List<StudentToCourse> student)
    {
        return student.Select(x => Covert(x)).ToList();
    }
    public static List<StudentToCourse> Covert(List<StudentToCourseDTO> student)
    {
        return student.Select(x => Covert(x)).ToList();
    }
    public static StudentToCourse Convert(StudentToCourseDTO student)
    {
        if (student == null)
            return null;
        return new StudentToCourse()
        {
            CourseId = student.CourseId,
            UserId = student.UserId
        };
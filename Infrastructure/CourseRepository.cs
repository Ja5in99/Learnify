using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Entity.Interfaces;

namespace Infrastructure
{
    public class CourseRepository : ICourseRepository
    {
        Task<Course> GetCourseByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        Task<IReadOnlyList<Course>> GetCoursesAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}
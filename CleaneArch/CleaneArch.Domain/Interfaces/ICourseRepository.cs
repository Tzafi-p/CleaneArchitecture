using CleaneArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleaneArch.Domain.Interfaces
{
   public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
        void Add(Course course);
    }
}

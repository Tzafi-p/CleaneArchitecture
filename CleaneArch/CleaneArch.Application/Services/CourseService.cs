using CleaneArch.Application.Interfaces;
using CleaneArch.Application.ViewModels;
using CleaneArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleaneArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public CourseViewModel GetCourses()
        {
            return new CourseViewModel()
            {
                Courses = _courseRepository.GetCourses()
            };
        }
    }
}

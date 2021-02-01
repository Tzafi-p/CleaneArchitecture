using CleaneArch.Application.Interfaces;
using CleaneArch.Application.ViewModels;
using CleaneArch.Domain.Commands;
using CleaneArch.Domain.Core.Bus;
using CleaneArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleaneArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus;

        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus)
        {
            _courseRepository = courseRepository;
            _bus = bus;
        }

        public void CreateCourse(CourseViewModel courseViewModel)
        {
            var createCourseCommand = new CreateCourseCommand(
                courseViewModel.Name,
                courseViewModel.Description,
                courseViewModel.ImageURL
                );

            _bus.SendCommand(createCourseCommand);
                
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

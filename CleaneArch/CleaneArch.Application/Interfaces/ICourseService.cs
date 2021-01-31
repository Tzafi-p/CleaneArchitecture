using CleaneArch.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleaneArch.Application.Interfaces
{
  public interface ICourseService
    {
        CourseViewModel GetCourses();
    }
}

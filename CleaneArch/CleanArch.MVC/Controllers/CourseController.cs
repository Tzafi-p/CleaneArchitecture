using CleaneArch.Application.Interfaces;
using CleaneArch.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleaneArch.MVC.Controllers
{

    [Authorize]
    public class CourseController : Controller
    {       
        private ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        public IActionResult Index()
        {
            CourseViewModel modle = _courseService.GetCourses();
            return View(modle);
        }
    }
}

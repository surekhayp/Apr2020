using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GitDemo.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult ListAll()
        {
            return View();
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningControllers.Controllers
{
    public class DerivedController : Controller
    {
        public ViewResult Index() => View("Result", $"This is a derived controller");
    }
}

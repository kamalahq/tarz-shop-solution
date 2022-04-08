using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarz.WebUI.Areas.Admin.Controllers
{
    public class GenderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

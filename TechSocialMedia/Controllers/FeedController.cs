using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TechSocialMedia.Controllers
{
    public class FeedController : Controller
    {
        public IActionResult MainFeed()
        {
            return View();
        }
    }
}

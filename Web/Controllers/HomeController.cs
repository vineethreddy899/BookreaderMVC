using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;
using Web.Services;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEventPageService _eventPageService;

        public HomeController(IEventPageService eventPageService)
        {
            this._eventPageService = eventPageService;
        }
        [Route("")]
        public async Task<IActionResult> Index()
        {
            var eventList = await _eventPageService.GetEvents();
            return View(eventList);
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

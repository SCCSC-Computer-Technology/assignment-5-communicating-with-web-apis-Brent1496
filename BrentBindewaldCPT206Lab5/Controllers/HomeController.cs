using BrentBindewaldCPT206Lab5.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using BrentBindewaldCPT206Lab5.Services;

namespace BrentBindewaldCPT206Lab5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentProfileService _studentProfileService;

        public HomeController(ILogger<HomeController> logger, StudentProfileService studentProfileService)
        {
            _logger = logger;
            _studentProfileService = studentProfileService;
        }

        public async Task<IActionResult> Index()
        {
            var studentProfiles = await _studentProfileService.GetStudentProfilesAsync();
            return View(studentProfiles);
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

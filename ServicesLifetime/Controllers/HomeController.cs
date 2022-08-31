using ServicesLifetime.Abstract;
using Microsoft.AspNetCore.Mvc;
using ServicesLifetime.Models;
using System.Diagnostics;

namespace ServicesLifetime.Controllers
{
    public class HomeController : Controller
    {
        private ISingletonService _singleton;
        private IScopedService _scoped;
        private ITransientService _transient;

        public HomeController(ISingletonService singleton, IScopedService scoped, ITransientService transient)
        {
            _singleton = singleton;
            _scoped = scoped;
            _transient = transient;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Singleton()
        {
            return View(_singleton.GetRandomNumber());
        }

        public IActionResult Scoped()
        {
            return View(_scoped.GetRandomNumber());
        }

        public IActionResult Transient()
        {
            return View(_transient.GetRandomNumber());
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
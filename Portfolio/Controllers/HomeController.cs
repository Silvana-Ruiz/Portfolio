using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using Portfolio.Services;
using System.Diagnostics;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProjectsRepo projectsRepo;
        private readonly IConfiguration configuration;

        public HomeController(ILogger<HomeController> logger, 
            IProjectsRepo projectsRepo,
            IConfiguration configuration)
        {
            _logger = logger;
            this.projectsRepo = projectsRepo;
            this.configuration = configuration;
        }

        public IActionResult Index()
        {
            var apellido = configuration.GetValue<string>("Apellido");
            _logger.LogTrace("Este es un mensaje de trace");
            _logger.LogDebug("Este es un mensaje de debug");
            _logger.LogInformation("Este es un mensaje de log");
            _logger.LogWarning("Este es un mensaje de warning");
            _logger.LogError("Este es un mensaje de error");
            _logger.LogCritical("Este es un mensaje de critical" + apellido);
            

            //var projectsRepo = new ProjectsRepo(); //Instance of a class Projectsrepo
            var projects = projectsRepo.GetProjectDTOs().Take(3).ToList();
     
            var model = new HomeIndexViewModel() 
            { 
                Projects = projects
            };
            return View(model);
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
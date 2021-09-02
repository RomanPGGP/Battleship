using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    /// <summary>
    /// Home controller for the welcome, about, contact and privacy page.
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Attribute ShipUser needed to save the username. 
        /// </summary>
        static public Player ShipUser = new Player();

        /// <summary>
        /// General welcome page.  
        /// </summary>
        /// <returns>Returns general index view for the game. Welcome page.</returns>
        public IActionResult Index()
        {
            return View("Index", ShipUser);
        }
        
        /// <summary>
        ///  About page served by this method. Taken from Views/About.
        /// </summary>
        /// <returns>Returns About page. Information for the developers.To be implemented.</returns>
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        /// <summary>
        ///  Serves contact information. Taken by Views/Contact.
        /// </summary>
        /// <returns>Returns Contact page. Information to contact the developers. To be implemented.</returns>
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        /// <summary>
        /// Privacy page served from Views/Privacy
        /// </summary>
        /// <returns>Returns Privacy page. Information for the clients privacy. To be implemented.</returns>
        public IActionResult Privacy()
        {
            return View();
        }

        /// <summary>
        /// Error handling.
        /// </summary>
        /// <returns> Predefined default error page.</returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

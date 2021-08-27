using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class BattleshipController : Controller
    {

        static public Battleship BattleshipBoard1 = new Battleship();

        public IActionResult Index()
        {
            return View("Index", BattleshipBoard1);
        }

        public IActionResult Game()
        {
            return View("Game", BattleshipBoard1);
        }

        public void PlaceShip()
        {

            View("Index", BattleshipBoard1);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
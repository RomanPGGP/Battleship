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

        public Battleship BattleshipBoard1;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Game()
        {
            int[,] myships = new int[5, 2] { { 0, 1 }, { 1, 1 }, { 2, 3 }, { 4, 4 }, { 1, 4 } };
            BattleshipBoard1 = new Battleship(myships);
            return View(BattleshipBoard1);
        }

        public void PlaceShip()
        {
            int row = 0;
            int col = 0;

            BattleshipBoard1.Place(row,col);
            Console.Out.Write(true);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
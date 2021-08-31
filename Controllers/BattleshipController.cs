using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class BattleshipController : Controller
    {

        static public Battleship BattleshipBoard1 = new Battleship();
        //Testing 
        static public int[,] pos = new int[5, 2] { { 0, 1 }, { 2, 3 }, { 2, 2 }, { 3, 1 }, { 2, 0 } };
        static public Battleship BattleshipEnemy = new Battleship(pos);
        static public List<Battleship> boards = new List<Battleship>{BattleshipBoard1,BattleshipEnemy};

        public IActionResult Index()
        {
            return View(BattleshipBoard1);
        }

        public IActionResult Game()
        {
            return View("Game", boards);
        }

        public IActionResult clickShipPos(string cell)
        {
            int coordenate = Int32.Parse(cell);
            int row = (coordenate/5);
            int col = (coordenate - (row * 5));

            if (BattleshipBoard1.Place(row, col))
            {
                return View("Index", BattleshipBoard1);
            }
            else
            {
                return View("Game", boards);
            }
        }

        public IActionResult attackClick(string cell)
        {
            int coordenate = Int32.Parse(cell);
            int row = (coordenate / 5);
            int col = (coordenate - (row * 5));
            BattleshipEnemy.Attack(row, col);

            if(BattleshipEnemy.CheckGameStatus())
            {
                return View("Index", BattleshipBoard1);
            }
            else
            {
                return View("Game", boards);
            }
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
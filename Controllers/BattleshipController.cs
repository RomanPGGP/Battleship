using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class BattleshipController : Controller
    {
        /// <summary>
        /// Game instance for player served.
        /// </summary>
        static public Battleship BattleshipBoard1 = new Battleship();
        
        ///<summary> Play against the computer set up.</summary> 
        static public int[,] pos = new int[5, 2] { { 0, 1 }, { 2, 3 }, { 2, 2 }, { 3, 1 }, { 2, 0 } };
        static public Battleship BattleshipEnemy = new Battleship(pos);
        static public List<Battleship> boards = new List<Battleship>{BattleshipBoard1,BattleshipEnemy};


        /// <summary>
        /// Returns first game page. Ship placement.
        /// </summary>
        /// <returns>Returns view for the index page of the game. Ships placement.</returns>
        public IActionResult Index()
        {
            int[,] pos = new int[5, 2];
            Random posGen = new Random();

            BattleshipEnemy.restart();
            BattleshipBoard1.restart();

            for (int i = 0; i < 5; i++)
            {
                int coordenate = posGen.Next(i, 24);
                int row = (coordenate / 5);
                int col = (coordenate - (row * 5));
                pos[i, 0] = row;
                pos[i, 1] = col;
            }

            Battleship newBoard = new Battleship(pos);
            BattleshipEnemy.grid = newBoard.grid;

            return View(BattleshipBoard1);
        }

        /// <summary>
        /// Battleship game view.
        /// </summary>
        /// <returns>View to the boards and the game.</returns>
        public IActionResult Game()
        {
            return View("Game", boards);
        }

        /// <summary>
        /// Ship placement, to start playing.
        /// </summary>
        /// <param name="cell"> Cell position to place ship. </param>
        /// <returns> View to the board, refreshed with new ships.</returns>
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

        /// <summary>
        /// Attack function to look for ships and if found sink them.
        /// </summary>
        /// <param name="cell"> Board coordinates for the attack </param>
        /// <returns> View to the updated board.</returns>
        public IActionResult attackClick(string cell)
        {
            int coordenate = Int32.Parse(cell);
            int row = (coordenate / 5);
            int col = (coordenate - (row * 5));
            BattleshipEnemy.Attack(row, col);

            if (BattleshipEnemy.CheckGameStatus())
            {
                return View("Game", boards);
            }

            //Attack my board
            Random PosGen = new Random();
            int rowSelf = PosGen.Next(0, 4);
            int colSelf = PosGen.Next(0, 4);

            BattleshipBoard1.Attack(rowSelf, colSelf);

            if(BattleshipBoard1.CheckGameStatus())
            {

                return View("Game", boards);
            }
            else
            {
                return View("Game", boards);
            }
            
        }

        /// <summary>
        /// Error handling.
        /// </summary>
        /// <returns>Error default page.</returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Battleship
    {
        /// <summary>
        /// Board to place ships and receive attacks.
        /// </summary>
        public int[,] grid { get; set; } = new int[5, 5];

        /// <summary>
        /// Number of ships sunk.
        /// </summary>
        public int hits = 0;

        /// <summary>
        /// Ships places in the board.
        /// </summary>
        public int ShipsPlaced = 0;

        /// <summary>
        /// Battleship constructor.
        /// </summary>
        public Battleship()
        {
            hits = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    grid[i, j] = 0;
                }
            }
        }

        /// <summary>
        /// Constructor with set of positions for ships.
        /// </summary>
        /// <param name="positions"></param>
        public Battleship(int[,] positions)
        {
            for (int i = 0; i < 5; i++)
            {
                grid[positions[i, 0], positions[i, 1]] = 1;
            }
        }

        /// <summary>
        /// Destructor for battleship class.
        /// </summary>
        ~Battleship()
        {
            ShipsPlaced = 0;
            hits = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    grid[i, j] = 0;
                }
            }
        }

        /// <summary>
        /// Method to place ships.
        /// </summary>
        /// <param name="row">Row of the grid</param>
        /// <param name="col">Column of the grid</param>
        /// <returns>Status if all 5 ships have been placed.</returns>
        public bool Place(int row, int col)
        {
            if (ShipsPlaced <= 4)
            {
                if (grid[row, col] == 0)
                {
                    grid[row, col] = 1;
                    ShipsPlaced++;
                }   
            }

            return (ShipsPlaced < 5);
        }

        /// <summary>
        /// Method to attack ships.
        /// </summary>
        /// <param name="row">Row of the grid for the attack.</param>
        /// <param name="col">Column of the grid for the attack.</param>
        /// <returns>Return status of the attack. Hit or not.</returns>
        public bool Attack(int row, int col)
        {
            if (grid[row, col]==1)
            {
                grid[row, col] = 2;
                hits++;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Checks if all of the ships have been sunk.
        /// </summary>
        /// <returns></returns>
        public bool CheckGameStatus()
        {
            return (hits >= 5); 
        }

        /// <summary>
        /// Restart both boards for the next game.
        /// </summary>
        public void restart()
        {
            ShipsPlaced = 0;
            hits = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    grid[i, j] = 0;
                }
            }
        }
    }
}

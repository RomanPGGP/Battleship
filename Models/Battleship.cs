using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Battleship
    {
        public int[,] grid { get; } = new int[5, 5];
        public int hits = 0;
        public int ShipsPlaced = 0;
        public string Username { get; set; }
        public int BoardID { get; set; }

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

        public Battleship(int[,] positions)
        {
            for (int i = 0; i < 5; i++)
            {
                grid[positions[i, 0], positions[i, 1]] = 1;
            }
        }

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

        public bool CheckGameStatus()
        {
            return (hits >= 5); 
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Battleship
    {
        public bool[,] grid = new bool[5, 5] { {false, false, false, false, false}, 
                                               {false, false, false, false, false}, 
                                               {false, false, false, false, false}, 
                                               {false, false, false, false, false}, 
                                               {false, false, false, false, false}};
        public Ship[] ships = new Ship[5];

        public Battleship(int[,] positions)
        {
            for (int i = 0; i < 5; i++)
            {
                ships[i].row = positions[i,0];
                ships[i].col = positions[0, i];

                grid[positions[i, 0], positions[0, i]] = true;
            }
        }

        public bool Attack(int row, int col)
        {
            if (grid[row, col])
            {
                return true;
            }

            return false;
        }

        public bool CheckGameStatus()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (!grid[i, j])
                    {
                        return true;
                    }
                }
            }

            return false;
        }

    }
}

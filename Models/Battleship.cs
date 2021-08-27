﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Battleship
    {
        public bool[,] grid { get; } = new bool[5, 5] { {false, false, false, false, false},
                                                        {false, false, false, false, false},
                                                        {false, false, false, false, false},
                                                        {false, false, false, false, false},
                                                        {false, false, false, false, false}};
        public Ship[] ships = new Ship[5];
        public int hits = 0;

        public Battleship(int[,] positions)
        {
            for (int i = 0; i < 5; i++)
            {
                grid[positions[i, 0], positions[i, 1]] = true;
            }
        }

        public void Place(int row, int col)
        {
            grid[row, col] = true;
        }

        public bool Attack(int row, int col)
        {
            if (grid[row, col])
            {
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

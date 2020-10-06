using System;

namespace Console_sweeper
{
    public class SweeperGrid
    {
        int[,] grid = new int[12, 15];

        static Random generator = new Random();

        public SweeperGrid()
        {
            for (int x = 0; x < grid.GetLength(0); x++)
            {
                for (int y = 0; y < grid.GetLength(1); y++)
                {
                    grid[x, y] = 9;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                int bombPlaceX = generator.Next(1,grid.GetLength(0));
                int bombPlaceY = generator.Next(1,grid.GetLength(1));
                grid[bombPlaceX, bombPlaceY] = 10;

            }
        }

        public bool CheckPosition(int x, int y)
        {
            if (x < 0 || x > grid.GetLength(0))
            {
                return false;
            }
            else if (y < 0 || y > grid.GetLength(1))
            {
                return false;
            }
            
            return grid[x, y] == 10;

        }

        

        public void Draw()
        {
            string bomb = "X";
            string empty = "█";

            for (int xDraw = 0; xDraw < grid.GetLength(0); xDraw++)
            {
                for (int yDraw = 0; yDraw < grid.GetLength(1); yDraw++)
                {
                    if (grid[xDraw, yDraw] == 10)
                    {
                        Console.Write(bomb);
                    }
                    else
                    {
                        Console.Write(empty);
                    }
                }
                Console.WriteLine();
            }
        }

    }
}

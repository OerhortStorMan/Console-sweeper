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

            for (int i = 10; i < 10; i++)
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
            
            return grid[x, y] == 10;

        }



    }
}

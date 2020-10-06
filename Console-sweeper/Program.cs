using System;

namespace Console_sweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            SweeperGrid gameGrid = new SweeperGrid();
System.Console.WriteLine("Grid:et är 12 x 15");
            gameGrid.Draw();

            bool game = true;
            while (game)
            {
            System.Console.WriteLine("Skriv en Y pos");
            string xInput = Console.ReadLine();
// Y POS OCH X POS BLANDAS IHOP
            int.TryParse(xInput, out int xInputInt);

            System.Console.WriteLine("Skriv en X pos");
            string yInput = Console.ReadLine();

            int.TryParse(yInput, out int yInputInt);

            Console.WriteLine(gameGrid.CheckPosition(xInputInt, yInputInt));

            if (true)
            {
                
            }

            }
        }
    }
}

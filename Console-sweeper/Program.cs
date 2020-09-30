using System;

namespace Console_sweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            SweeperGrid gameGrid = new SweeperGrid();

            // Console.Write(gameGrid);
            System.Console.WriteLine("Skriv två positioner som x,y");
            string xInput = Console.ReadLine();
            
            int.TryParse(xInput, out int xInputInt);

            System.Console.WriteLine("Skeiv en Y pos");
            string yInput = Console.ReadLine();

            int.TryParse(yInput, out int yInputInt);

            Console.WriteLine(gameGrid.CheckPosition(xInputInt, yInputInt));

            Console.ReadLine();
        }
    }
}

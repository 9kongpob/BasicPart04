using System;

namespace BasicPart04_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            string color = "";
            Console.WriteLine("1 : Car Red");
            Console.WriteLine("2 : Car Black");
            Console.WriteLine("3 : Car White");
            Console.Write("Input your Car Color : ");
            int.TryParse(Console.ReadLine(),out choice);

            switch (choice)
            {
                case 1:
                    color = "Red";
                    break;
                case 2:
                    color = "Black";
                    break;
                case 3:
                    color = "White";
                    break;
                default:
                    color = "Default";
                    break;
            }
            Console.WriteLine("Color your car : " + color);
            Console.ReadKey();
        }

    }
}

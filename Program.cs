using System;
using System.Threading;

namespace elevator_csharp_ds
{
    public class Program
    {
        private const string QUIT = "q";

        public static void Main(string[] args)
        {
            Start:
				Console.WriteLine ("Welcome to Avishek's elevator!!");
				Console.WriteLine ("What is the Building Height");

				int floor; string floorInput; Elevator elevator;
			    
				floorInput = Console.ReadLine();

				if (Int32.TryParse (floorInput, out floor))
					elevator = new Elevator (floor);
				else {
					Console.WriteLine ("That' doesn't make sense...");
					Console.Beep();
					Thread.Sleep(2000);
					Console.Clear();
					goto Start;
				}
				string input = string.Empty;

				while (input != QUIT) 
				{
					Console.WriteLine ("Please press which floor you would like to go to");

					input = Console.ReadLine ();
					if (Int32.TryParse (input, out floor))
						elevator.FloorPress (floor);
					else if (input == QUIT)
						Console.WriteLine ("GoodBye!");
					else
						Console.WriteLine ("You have pressed an incorrect floor, Please try again");
				}
        }
    }
}

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Open the Program.cs file and declare and assign three string variables for three different types of flooring each with a price per square
            //foot (perhaps "Hardwood ($8.95/sq.ft.)" as an example - come up with something original, here). - Joshua Junnola-Nagy

            Console.WriteLine("Please choose between one of the following options.");
            Console.WriteLine("===================================================");

            string A = "A) Laminated flooring avg: $4.30/sq.ft.";
            string B = "B) Tiled flooring avg: $27.50/sq.ft.";
            string C = "C) Vinyl flooring avg: $3.50/sq.ft.";
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
            Console.WriteLine("===================================================");
            Console.WriteLine("Enter your choice (A, B, or C): ");

            //Declare a variable to capture the user's choice of flooring type. - Joshua Junnola-Nagy
            while (true)
            {
                string selectedFlooring = Console.ReadLine();

                if (selectedFlooring == "A" || selectedFlooring == "B" || selectedFlooring == "C")
                {
                    Console.WriteLine($"You have selected option {selectedFlooring}.");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid selection, Please choose from A, B, or C.");
                }
            }
            //Declare two variables to represent the length and width of a room (using feet measured to one decimal point). - Joshua Junnola-Nagy

            double roomLengthfeet;
            double roomWidthfeet;

            //Krista Paradis
            //Ask the user the length of the room they are looking to install the new flooring.

            Console.WriteLine("Please enter the length of the room in feet (to one decimal point): ");

            //Check to see that the user has inputted a number - if yes, then store this value in the length
            //variable created in step 4, if no then output an appropriate error message to the console.

            if (double.TryParse(Console.ReadLine(), out roomLengthfeet))
            {
                Console.WriteLine($"Room length recorded: {roomLengthfeet} feet.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            //Ask the user the width of the room they are looking to install the new flooring.

            Console.WriteLine("Please enter the width of the room in feet (to one decimal point): ");

            //Check to see that the user has inputted a number - if yes, then store this value in the length variable created in step 4, if no
            //then output an appropriate error message to the console.

            if (double.TryParse(Console.ReadLine(), out roomWidthfeet))
            {
                Console.WriteLine($"Room width recorded: {roomWidthfeet} feet.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}

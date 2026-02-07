using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Write("\nEnter the first whole number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second whole number: ");
            int num2 = int.Parse(Console.ReadLine());

            string op = "";

            // Loop forever until we hit a 'break'
            while (true)
            {
                Console.Write("Choose an operation (+, -, *, /, %, or = to Exit): ");
                op = Console.ReadLine();

                if (op == "=")
                {
                    running = false;
                    break; // Exits the 'while (true)' loop
                }

                if (op == "+" || op == "-" || op == "*" || op == "/" || op == "%")
                {
                    break; // Exits the 'while (true)' loop because input is valid
                }

                Console.WriteLine("Incorrect Operation Used, please try again");
            }

            if (running)
            {
                double? result = Calculator.Calculate(num1, num2, op);

                if (result != null)
                {
                    Console.WriteLine("Result: " + result);
                }
            }
        }

        Console.WriteLine("Program Terminated.");
    }
}

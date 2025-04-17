using Ekvip_Test.Models;
class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Please provide an initial value as a command line argument.");
            return;
        }

        if (!int.TryParse(args[0], out int initialValue))
        {
            Console.WriteLine("Invalid initial value. Please provide a valid number.");
            return;
        }

        Calculator calculator = new Calculator(initialValue);
        Console.WriteLine("Initial value: {0}", calculator.Result);

        while (true)
        {
            Console.Write("Enter command (increment, decrement, double, randadd, undo): ");
            string input = Console.ReadLine().Trim();

            calculator.ProcessCommand(input);
            Console.WriteLine("Result: {0}", calculator.Result);
        }
    }
}



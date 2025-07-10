internal class Program
{
    private static void Main(string[] args)
    {
        double num1 = 0;
        double num2 = 0;
        double result = 0;

        Console.WriteLine("Hi!");

        Console.WriteLine("Let do some calculation");
       
       

        Console.Write("Enter number 1: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter number 2: ");
        num2 = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("Enter an option: ");
        Console.WriteLine("\t+ : Add");
        Console.WriteLine("\t- : Subtract");
        Console.WriteLine("\t* : Multiply");
        Console.WriteLine("\t/ : Divide");

        switch (Console.ReadLine())
        {
            case "+":
                result = num1 + num2;
                Console.WriteLine($"Result: {num1} + {num2} = {result}");
                break;
            case "-":
                result = num1 - num2;
                Console.WriteLine($"Result: {num1} - {num2} = {result}");
                break;
            case "*":
                result = num1 * num2;
                Console.WriteLine($"Result: {num1} * {num2} = {result}");
                break;
            case "/":
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"Result: {num1} / {num2} = {result}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;
            default:
                Console.WriteLine("Invalid option selected.");
                break;
        }

        



    }
}
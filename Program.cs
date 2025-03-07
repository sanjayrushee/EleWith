using System;

class Program
{
    static int Operation(int number_one, int number_two, char symbol)
    {
        switch (symbol)
        {
            case '+':
                return number_one + number_two;
            case '-':
                return number_one - number_two;
            case '*':
                return number_one * number_two;
            case '/':
                if (number_two != 0)
                    return number_one / number_two;
                else
                {
                    Console.WriteLine("Cannot divide by zero!");
                    return 0;
                }
            default:
                Console.WriteLine("Invalid operator!");
                return 0;
        }
    }

    static void Main()
    {
        Console.Write("Enter first number: ");
        int number_one = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int number_two = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter operator (+, -, *, /): ");
        char symbol = Convert.ToChar(Console.ReadLine());

        int result = Operation(number_one, number_two, symbol);
        Console.WriteLine("Result: " + result);
    }
}

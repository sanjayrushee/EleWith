using System;

class Program
{
       static int Maths(int number_one, int number_two, char symbol)
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
        Console.Write("Enter the numbers: ");
        string input = Console.ReadLine();
        string[] parts = input.Split(' ');
        char symbol = Convert.ToChar(parts[1]);
        int number_one = Convert.ToInt32(parts[0]);
        int number_two = Convert.ToInt32(parts[2]);


        int result = Maths(number_one, number_two, symbol);
        Console.WriteLine("Result: " + result);
    }
}

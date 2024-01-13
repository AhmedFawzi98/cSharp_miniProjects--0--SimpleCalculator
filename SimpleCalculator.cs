namespace Simple_Calculator;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello");
        Console.WriteLine("please, enter 1st number : ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("please, enter 2nd number : ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("What do you want to do with those numbers? \n");
        Console.WriteLine("[A]dd\n[S]ubtract\n[M]ultiply");

        string inputChoice = Console.ReadLine();
        Calculate(inputChoice.ToLower(), firstNumber, secondNumber);



    }
    static void Calculate(string Choice, int first, int second)
    {
        if (Choice == "a")
            PrintResult(first, second, "+", first + second);
        else if (Choice == "s")
            PrintResult(first, second, "-", first - second);
        else if (Choice == "m")
            PrintResult(first, second, "*", first * second);
        else
            Console.WriteLine("Invalid Option");
    }
    static void PrintResult(int first, int second, string @operator, int result)
    {
        Console.WriteLine($"{first} {@operator} {second} = {result}");
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        ShowMenu();
    }

    static void ShowMenu()
    {
        Console.Clear();
        Console.WriteLine("Select an option:: \n1 - SUM \n2 - SUBTRACTION \n3 - DIVISION \n4 - MULTIPLICATION \n5 - EXIT");
        Console.WriteLine("-----------------");

        short answer = short.Parse(Console.ReadLine());

        switch (answer)
        {
            case 1: Sum(); break;
            case 2: Subtraction(); break;
            case 3: Division(); break;
            case 4: Multiplication(); break;
            case 5: System.Environment.Exit(0); break;
            default: ShowMenu(); break;
        }
    }

    static void Sum()
    {
        Console.Clear();

        Console.WriteLine("Enter the first value: ");
        float firstValue = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second value: ");
        float secondValue = float.Parse(Console.ReadLine());

        float result = firstValue + secondValue;
        Console.WriteLine($"The sum of {firstValue} + {secondValue} = {result}");

        Console.ReadKey();
        ShowMenu();
    }

    static void Subtraction()
    {
        Console.Clear();

        Console.WriteLine("Enter the first value: ");
        float firstValue = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second value: ");
        float secondValue = float.Parse(Console.ReadLine());

        float result = firstValue - secondValue;
        Console.WriteLine($"The Subtraction of {firstValue} - {secondValue} = {result}");

        Console.ReadKey();
        ShowMenu();
    }

    static void Division()
    {
        Console.Clear();

        Console.WriteLine("Enter the first value: ");
        float firstValue = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second value: ");
        float secondValue = float.Parse(Console.ReadLine());

        float result = firstValue / secondValue;
        Console.WriteLine($"The Division of {firstValue} / {secondValue} = {result}");

        Console.ReadKey();
        ShowMenu();
    }

    static void Multiplication()
    {
        Console.Clear();

        Console.WriteLine("Enter the first value: ");
        float firstValue = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second value: ");
        float secondValue = float.Parse(Console.ReadLine());

        float result = firstValue * secondValue;
        Console.WriteLine($"The Multiplication of {firstValue} * {secondValue} = {result}");

        Console.ReadKey();
        ShowMenu();
    }




}
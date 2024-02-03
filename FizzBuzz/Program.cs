internal class FizzBuzzProgram
{
    static void Main()
    {
        int userNum;
        Console.WriteLine("Enter the number you wish to count to.");
        Console.WriteLine();
        try
        {
            userNum = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid input, did you input a number?");
            throw;
        }
        Console.WriteLine();
        for (int i = 1; i <= userNum; i++)
        {
            Console.WriteLine($"{i} is {FizzbuzzChecker(i)}");
        }

        static string FizzbuzzChecker(int number)
        {
            string _result;
            if (number % 3 == 0 && number % 5 == 0) { _result = "Fizzbuzz"; } // If number is divisible by both 3 and 5 we have fizzbuzz.
            else if (number % 5 == 0) { _result = "Buzz"; }
            else if (number % 3 == 0) { _result = "Fizz"; }
            else _result = "neither";
            return _result;
        }
        Console.WriteLine();
        Console.WriteLine("Any key to close.");
        Console.ReadKey();
        Environment.Exit(0);
    }
}
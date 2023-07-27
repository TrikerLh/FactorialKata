namespace FactorialKata.Tests;

public class Factorial
{
    public static int Get(int number)
    {
        if(number == 0) return 1;
        return number * Get(number - 1);
    }
}
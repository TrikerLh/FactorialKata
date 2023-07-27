namespace FactorialKata.Tests;

public class Factorial
{
    public static int Get(int number)
    {
        if(number == 0) return 1;
        var result = number * (number - 1);
        for (var i = number - 1; i > 1; i--)
        {
            result *= (i - 1);
        }

        return result;
    }
}
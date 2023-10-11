public class Program
{
    static void Main()
    {
        Console.WriteLine( "Input array length: ");
        int length = Convert.ToInt32( Console.ReadLine() );
        Console.Write( "Input array of number: " );
        List<int> nums = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32).ToList();
        
        PlusMinus( nums );
    }

    private static void PlusMinus(List<int> arr)
    {
        int length = arr.Count;
        double positive = 0;
        double negative = 0;
        double zero = 0;
        
        NumbersCount(arr, length, ref positive, ref negative, ref zero);
        RatiosPrinter(positive, length, negative, zero);
    }

    private static void NumbersCount(List<int> arr, int length, ref double positive, ref double negative, ref double zero)
    {
        for (int i = 0; i < length; i++)
        {
            IfPositive(arr, ref positive, i);
            IfNegative(arr, ref negative, i);
            IfZero(arr, ref zero, i);
        }
    }

    private static void IfPositive(List<int> arr, ref double positive, int i)
    {
        if (arr[i] > 0)
        {
            positive++;
        }
    }

    private static void IfNegative(List<int> arr, ref double negative, int i)
    {
        if (arr[i] < 0)
        {
            negative++;
        }
    }

    private static void IfZero(List<int> arr, ref double zero, int i)
    {
        if (arr[i] == 0)
        {
            zero++;
        }
    }

    private static void RatiosPrinter(double positive, int length, double negative, double zero)
    {
        Console.WriteLine("{0:N6}", (positive / length));
        Console.WriteLine("{0:N6}", (negative / length));
        Console.WriteLine("{0:N6}", (zero / length));
    }
}
public class Program
{
    static void Main()
    {
        int median = FindMedian( new List<int>() {0, 1, 2, 4, 6, 5, 3} );
        int median2 = FindMedian( new List<int>() { 4, 8, 6, 2 } );
        Console.WriteLine( "Median: " + median );
        Console.WriteLine( "Median2: " + median2 );
    }

    public static int FindMedian(List<int> arr)
    {
        arr.Sort();
        int median;
        
        int dataCount = arr.Count;
        if ( dataCount % 2 != 0 )
        {
            median = arr[( ( dataCount + 1 ) / 2 ) - 1];
        }
        else
        {
            median = ( arr[( dataCount / 2 ) - 1] + arr[( ( dataCount / 2 ) + 1 ) - 1] ) / 2;
        }

        return median;
    }
}
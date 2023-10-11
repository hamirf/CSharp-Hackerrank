public class Program
{
    static void Main()
    {
        Console.Write( "Input array of number: " );
        List<int> nums = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32).ToList();
        // MiniMaxSum( new List<int>() { 426980153, 354802167, 142980735, 968217435, 734892650 } );
        MiniMaxSum( nums );
    }
    
    public static void MiniMaxSum(List<int> arr)
    {
        arr.Sort();
        Int64 minSum = 0;
        Int64 maxSum = 0;
        
        for( int i = 0; i < arr.Count; i++ )
        {
            if( i < arr.Count - 1 )
            {
                minSum += arr[i];                
            }
            
            if( i > 0 )
            {
                maxSum += arr[i];
            }
        }

        Console.WriteLine( $"{minSum} {maxSum}" );
    }
}
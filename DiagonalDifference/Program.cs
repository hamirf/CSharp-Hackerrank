public class Program
{
    static void Main()
    {
        int result = diagonalDifference( new List<List<int>>()
        {
            new List<int>() { 11, 2, 4 },
            new List<int>() {4, 5 ,6},
            new List<int>() {10, 8, -12}
        } );

        Console.WriteLine("Result : " + result);
    }
    
    public static int diagonalDifference(List<List<int>> arr)
    {
        int lr = 0;
        int rl = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            for (int j = 0; j < arr.Count; j++)
            {
                if ( i == j )
                {
                    lr += arr[i][j];
                } 
                
                if ( i + j == arr.Count - 1 )
                {
                    rl += arr[i][j];
                }
            }
        }
        
        return Math.Abs( lr - rl );
    }
}
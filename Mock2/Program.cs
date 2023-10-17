public class Program
{
    static void Main()
    {
        var matrix = new List<List<int>>() { new List<int>() { 1, 2 }, new List<int>() { 3, 4 } };
        int result = FlippingMatrix(matrix);
        Console.WriteLine("Result: " + result);
    }
    
    public static int FlippingMatrix(List<List<int>> matrix)
    {
        Console.WriteLine("List count: " + matrix.Count);
        int n = matrix.Count / 2;
        int result = 0;
        for (int i = 0; i < matrix.Count; i++)
        {
            for (int j = 0; j < matrix.Count; j++)
            {
                var temp = new List<int>
                {
                    matrix[i][j],
                    matrix[i][2 * n - j - 1],
                    matrix[2 * n - i - 1][j],
                    matrix[2 * n - i - 1][2 * n - j - 1]
                };
                result += temp.Max();
            }
        }

        return result;
    }
}
public class Program
{
    static void Main()
    {
        Console.WriteLine("Input number of items: ");
        int n = Convert.ToInt32( Console.ReadLine() );

        Console.WriteLine("Input element of array: ");
        List<int> nums = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32 ).ToList();
        var frequency = CountingSort(nums);

        foreach (var freq in frequency)
        {
            Console.WriteLine("Frequency: " + freq);
        }
    }
    
    private static List<int> CountingSort(List<int> arr)
    {
        var arrFreq = new int[100];

        for (int i = 0; i < arrFreq.Length; i++)
        {
            arrFreq[i] = 0;
        }
        
        var freq = arrFreq.ToList();
        
        foreach (var num in arr)
        {
            freq[num]++;
        }

        return freq;
    }
}
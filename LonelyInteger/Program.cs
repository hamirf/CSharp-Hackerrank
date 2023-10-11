public class Program
{
    static void Main()
    {
        Console.WriteLine( "LINQ Unique: " + LonelyIntegerLINQ( new List<int>() {1,  2, 3, 4, 3, 2, 1} ) );
        Console.WriteLine( "No LINQ Unique: " + LonelyInteger( new List<int>() {1,  2, 3, 4, 3, 2, 1} ) );
    }
    
    public static int LonelyIntegerLINQ(List<int> a)
    {
        int noDupe = 0;

        var unique = a.GroupBy(num => num).FirstOrDefault(num => num.Count() == 1);

        foreach (var num in unique!)
        {
            noDupe = num;
        }
        
        return noDupe;
    }
    private static int LonelyInteger(List<int> a)
    {
        int noDupe = 0;
        var intDict = new Dictionary<int, int>();

        foreach (var num in a)
        {
            if ( !intDict.ContainsKey( num ) )
            {
                intDict.Add( num, 1 );
            }
            else
            {
                intDict[num]++;
            }
        }

        foreach (var kvp in intDict)
        {
            if (kvp.Value == 1)
            {
                noDupe = kvp.Key;
            }
        }
        
        return noDupe;
    }
}
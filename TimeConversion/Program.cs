public class Program
{
    static void Main()
    {
        TimeConversion("07:05:45PM");
    }
    
    public static string TimeConversion(string s)
    {
        if( s.Substring( 8 ).Equals( "PM" ) )
        {
            s.Replace( "PM" , " PM" );
        } else 
        {
            s.Replace( "AM" , " AM" );            
        }
        DateTime time = DateTime.Parse( s );
        
        return time.ToString( "HH:mm:ss" );
    }
}
public class Program
{
    static void Main()
    {
        Console.WriteLine( "Select option below: " );
        Console.WriteLine( "1. Factorial Calculation" );
        Console.WriteLine( "2. Power Calculation" );
        Console.Write( "Selected option: ");
        long option = Convert.ToInt64( Console.ReadLine() );
        
        OptionSelector( option );
    }

    private static void OptionSelector( long option )
    {
        if ( option == 1 ) FactorialCalculation();
        else if ( option == 2 ) PowerCalculation();
    }

    private static void FactorialCalculation()
    {
        long num = FactorialInput();
        FactorialResult( num );
    }

    private static void PowerCalculation()
    {
        PowerInput( out long number, out long pow );
        PowerResult( number, pow );
    }

    private static long FactorialInput()
    {
        Console.Clear();
        Console.WriteLine( "==================== Factorial Calculation ====================" );
        Console.Write( "Input number: " );
        long num = Convert.ToInt64( Console.ReadLine() );
        return num;
    }

    private static void FactorialResult( long num )
    {
        long factorial = Factorial( num );
        Console.WriteLine();
        Console.Write( "Result: " );
        Console.WriteLine( $"{num}! is equal to {factorial}" );
        Console.WriteLine( "==================== Factorial Calculation ====================" );
    }

    private static void PowerInput( out long number, out long pow )
    {
        Console.Clear();
        Console.WriteLine( "==================== Power Calculation ====================" );
        Console.Write( "Input number: " );
        number = Convert.ToInt64( Console.ReadLine() );

        Console.Write( "Input power: " );
        pow = Convert.ToInt64( Console.ReadLine() );
    }

    private static void PowerResult( long number, long pow )
    {
        long power = Power( number, pow );
        Console.WriteLine();
        Console.Write( "Result: " );
        Console.WriteLine( $"{number} to the power of {pow} is equal to {power}" );
        Console.WriteLine( "==================== Power Calculation ====================" );
    }

    private static long Power( long num, long pow )
    {
        if ( pow == 0 )
        {
            return 1;
        }

        return num * Power( num, pow - 1 );
    }

    private static long Factorial( long num )
    {
        if ( num == 0 )
        {
            return 1;
        }

        return num * Factorial( num - 1 );
    }
}
namespace SimpleCalculator.Reader;

public class ConsoleReader : IReader
{
    public string? ReadLine()
    {
        return Console.ReadLine();
    }
    
    public double ReadNumber()
    {
        var input = ReadLine();
        if (double.TryParse(input, out var number))
        {
            return number;
        }
        throw new ArgumentException("Input is not a number");
    }
}
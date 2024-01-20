namespace SimpleCalculator.Reader;

public class ConsoleReader : IReader
{
    public string? ReadLine()
    {
        return Console.ReadLine();
    }
}
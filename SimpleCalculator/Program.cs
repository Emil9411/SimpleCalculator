using SimpleCalculator.Logger;
using SimpleCalculator.Service;
using SimpleCalculator.Reader;

namespace SimpleCalculator;

public static class Program
{
    public static void Main()
    {
        var logger = new ConsoleLogger();
        var reader = new ConsoleReader();
        var calculator = new Calculator();
        var calculatorService = new CalculatorService(calculator, reader, logger);
        calculatorService.Run();
    }
}

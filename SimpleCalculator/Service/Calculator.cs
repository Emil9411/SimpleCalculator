using SimpleCalculator.Logger;

namespace SimpleCalculator.Service;

public class Calculator : ICalculator
{
    private readonly ILogger _logger;

    public Calculator(ILogger logger)
    {
        _logger = logger;
    }
    
    public double Add(int a, int b)
    {
        var result = a + b;
        _logger.Log($"{a} + {b} = {result}");
        return result;
    }
    
    public double Subtract(int a, int b)
    {
        var result = a - b;
        _logger.Log($"{a} - {b} = {result}");
        return result;
    }
    
    public double Multiply(int a, int b)
    {
        var result = a * b;
        _logger.Log($"{a} * {b} = {result}");
        return result;
    }
    
    public double Divide(int a, int b)
    {
        var result = a / b;
        _logger.Log($"{a} / {b} = {result}");
        return result;
    }
}
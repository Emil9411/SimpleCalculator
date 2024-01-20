using SimpleCalculator.Logger;
using SimpleCalculator.Reader;

namespace SimpleCalculator.Service;

public class CalculatorService
{
    private readonly ICalculator _calculator;
    private readonly IReader _reader;
    private readonly ILogger _logger;
    
    public CalculatorService(ICalculator calculator, IReader reader, ILogger logger)
    {
        _calculator = calculator;
        _reader = reader;
        _logger = logger;
    }
    
    public void Run()
    {
        _logger.Log("Welcome to the Simple Calculator!");
        _logger.Log("=================================");
        _logger.Log("This calculator supports the following operations:");
        _logger.Log("+ (addition)");
        _logger.Log("- (subtraction)");
        _logger.Log("* (multiplication)");
        _logger.Log("/ (division)");
        _logger.Log("=================================");
        _logger.Log("Enter 'q' to quit.");
        _logger.Log("Enter 's' to start.");
        _logger.Log("=================================");
        while (_reader.ReadLine() != "q")
        {
            _logger.Log("Enter a number:");
            var a = _reader.ReadNumber();
            _logger.Log("Enter another number:");
            var b = _reader.ReadNumber();
            _logger.Log("Enter an operation (+, -, *, /):");
            var operation = _reader.ReadLine();
            var result = operation switch
            {
                "+" => _calculator.Add(a, b),
                "-" => _calculator.Subtract(a, b),
                "*" => _calculator.Multiply(a, b),
                "/" => _calculator.Divide(a, b),
                _ => throw new InvalidOperationException($"Unknown operation: {operation}")
            };
            _logger.Log($"Result: {result}");
            _logger.Log("=================================");
            _logger.Log("Enter 'q' to quit.");
            _logger.Log("Enter 's' to start another calculation.");
            _logger.Log("=================================");
        }
        _logger.Log("Goodbye!");
    }
}
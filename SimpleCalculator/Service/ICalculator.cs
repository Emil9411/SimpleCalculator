namespace SimpleCalculator.Service;

public interface ICalculator
{
    double Add(int a, int b);
    double Subtract(int a, int b);
    double Multiply(int a, int b);
    double Divide(int a, int b);
}
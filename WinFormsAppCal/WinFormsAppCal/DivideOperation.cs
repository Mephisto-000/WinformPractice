

public class DivideOperation : ICalculatorOperation
{
    public double Calculate(double x, double y) => y == 0 ? double.NaN : x / y;
}


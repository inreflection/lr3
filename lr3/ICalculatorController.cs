public interface ICalculatorController
{
    public double Add(params double[] numbers);

    public double Subtract(params double[] numbers);

    public double Multiply(params double[] numbers);

    public double Divide(params double[] numbers);
}
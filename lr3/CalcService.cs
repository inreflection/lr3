using System;

public class CalcService : ICalculatorController
{
    public double Add(params double[] numbers)
    {
        double sum = 0;
        foreach (double num in numbers)
        {
            sum += num;
        }
        return sum;
    }

    public double Subtract(params double[] numbers)
    {
        if (numbers.Length == 0)
        {
            throw new ArgumentException("At least one number must be provided.");
        }

        double result = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            result -= numbers[i];
        }
        return result;
    }

    public double Multiply(params double[] numbers)
    {
        if (numbers.Length == 0)
        {
            throw new ArgumentException("At least one number must be provided.");
        }

        double result = 1;
        foreach (double num in numbers)
        {
            result *= num;
        }
        return result;
    }

    public double Divide(params double[] numbers)
    {
        if (numbers.Length == 0)
        {
            throw new ArgumentException("At least one number must be provided.");
        }

        double result = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            result /= numbers[i];
        }
        return result;
    }
}
namespace TestApp.Services;

/// <summary>
/// Простий калькулятор для базових арифметичних операцій.
/// </summary>
public class Calculator
{
    /// <summary>Додавання двох чисел.</summary>
    public int Add(int a, int b) => a + b;

    /// <summary>Віднімання двох чисел.</summary>
    public int Subtract(int a, int b) => a - b;

    /// <summary>Множення двох чисел.</summary>
    public int Multiply(int a, int b) => a * b;

    /// <summary>Ділення двох чисел.</summary>
    public double Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Ділення на нуль неможливе.");
        }

        return (double)a / b;
    }
}

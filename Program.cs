using TestApp.Models;
using TestApp.Services;

// Тестове рішення для демонстрації роботи з системою контролю версій Git.
// Просте консольне застосування на C# (.NET 8).

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Лабораторна робота №2 — тестове рішення");
Console.WriteLine("=======================================");

// Демонстрація роботи калькулятора
var calculator = new Calculator();
int a = 8, b = 5;
Console.WriteLine($"{a} + {b} = {calculator.Add(a, b)}");
Console.WriteLine($"{a} - {b} = {calculator.Subtract(a, b)}");
Console.WriteLine($"{a} * {b} = {calculator.Multiply(a, b)}");
Console.WriteLine($"{a} / {b} = {calculator.Divide(a, b):F2}");

Console.WriteLine();

// Демонстрація роботи зі списком студентів
var students = new List<Student>
{
    new Student("Колесник Владислав", "31 ІПЗз", 92),
    new Student("Іваненко Петро", "31 ІПЗз", 78),
    new Student("Сидоренко Олена", "31 ІПЗз", 85),
};

Console.WriteLine("Список студентів:");
foreach (var student in students)
{
    Console.WriteLine($"  - {student}");
}

double average = students.Average(s => s.Grade);
Console.WriteLine($"\nСередній бал групи: {average:F1}");

namespace TestApp.Models;

/// <summary>
/// Модель, що описує студента.
/// </summary>
public class Student
{
    public string Name { get; set; }
    public string Group { get; set; }
    public int Grade { get; set; }

    public Student(string name, string group, int grade)
    {
        Name = name;
        Group = group;
        Grade = grade;
    }

    public override string ToString() => $"{Name} ({Group}) — {Grade} балів";
}

using System;

internal class Student
{
    public string Surname { get; set; }
    public DateTime Birthday { get; set; }
    public int Group { get; set; }
    public int[] Progress { get; set; }

    public Student()
    {
        Progress = new int[5];
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Фамилия: {Surname}");
        Console.WriteLine($"День рождение: {Birthday.ToString("dd.MM.yyyy")}");
        Console.WriteLine($"Номер группы: {Group}");
        Console.WriteLine("Оценки:");
        for (int i = 0; i < Progress.Length; i++)
        {
            Console.WriteLine($"   Grade {i + 1}: {Progress[i]}");
        }
    }
}
using System;

internal class Train
{
    public string Destination { get; set; }
    public DateTime DepartureTime { get; set; }
    public int NumberTrain { get; set; }

    public void PrintInfo()
    {
        Console.WriteLine($"Пункт назначения: {Destination}");
        Console.WriteLine($"Время отправления: {DepartureTime.ToString("HH")}");
        Console.WriteLine($"Номер поезда: {NumberTrain}");
    }
}
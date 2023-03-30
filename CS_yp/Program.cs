//****************************************Практическая 2.1***************************************************
//zadanie 1
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        string j = "ab";
//        string s = "aabbccd";
//        int res = s.Count(x => j.Contains(x));
//        Console.WriteLine("Количество символов: " + res);
//    }
//}



//zadanie 2
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        int[] candidates1 = { 2, 5, 2, 1, 2 };
//        int target1 = 5;
//        List<List<int>> result1 = CombinationSum(candidates1, target1);
//        Console.WriteLine($"[\n{string.Join("\n", result1.Select(x => $"[{string.Join(",", x)}]"))}\n]");

//        int[] candidates2 = { 10, 1, 2, 7, 6, 1, 5 };
//        int target2 = 8;
//        List<List<int>> result2 = CombinationSum(candidates2, target2);
//        Console.WriteLine($"[\n{string.Join("\n", result2.Select(x => $"[{string.Join(",", x)}]"))}\n]");
//    }

//    static List<List<int>> CombinationSum(int[] candidates, int target)
//    {
//        Array.Sort(candidates);
//        return CombinationSumHelper(candidates, target, 0);
//    }

//    static List<List<int>> CombinationSumHelper(int[] candidates, int target, int start)
//    {
//        List<List<int>> result = new List<List<int>>();
//        if (target == 0)
//        {
//            result.Add(new List<int>());
//            return result;
//        }
//        for (int i = start; i < candidates.Length && candidates[i] <= target; i++)
//        {
//            if (i > start && candidates[i] == candidates[i - 1]) continue;
//            foreach (List<int> combination in CombinationSumHelper(candidates, target - candidates[i], i + 1))
//            {
//                combination.Insert(0, candidates[i]);
//                result.Add(combination);
//            }
//        }
//        return result;
//    }
//}



//zadanie 3
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        int[] nums = { 1, 2, 3, 4 };
//        Console.WriteLine(SameNumbers(nums));
//        int[] nums2 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
//        Console.WriteLine(SameNumbers(nums2));
//    }

//    static bool SameNumbers(int[] nums)
//    {
//        bool res = nums.GroupBy(x => x).Any(g => g.Count() > 1);
//        return res;
//    }
//}
//***********************************************************************************************************



//****************************************Практическая 2.2***************************************************
//zadanie 1

//using System;

//class Program
//{
//    static void Main()
//    {
//        const int n = 5;
//        Student[] students = new Student[n];
//        int studentCount = 0;

//        while (true)
//        {
//            Console.Write("1 для добавления студента, 2 для вывода всех студентов, для выхода из программы 0: ");
//            string a = Console.ReadLine()!;

//            switch (a)
//            {
//                case "0":
//                    Console.WriteLine("Завершение программы...");
//                    return;
//                case "1":
//                    if (studentCount >= n)
//                    {
//                        Console.WriteLine("Невозможно добавить больше студентов");
//                        break;
//                    }

//                    Student student = new Student();

//                    Console.Write("Введите Фамилию: ");
//                    string surname = Console.ReadLine()!;
//                    student.Surname = surname;

//                    Console.Write("Введите день рождение (например, 01.01.2000): ");
//                    DateTime birthday = Convert.ToDateTime(Console.ReadLine());
//                    student.Birthday = birthday;

//                    Console.Write("Введите группу: ");
//                    int group = Convert.ToInt32(Console.ReadLine()!);
//                    student.Group = group;

//                    for (int i = 0; i < 5; i++)
//                    {
//                        Console.Write($"Введите оценку {i + 1}: ");
//                        int progress = Convert.ToInt32(Console.ReadLine()!);
//                        student.Progress[i] = progress;
//                    }

//                    students[studentCount] = student;
//                    studentCount++;
//                    break;

//                case "2":
//                    for (int i = 0; i < studentCount; i++)
//                    {
//                        Console.WriteLine($"Фамилия: {students[i].Surname},\nДата рождения: {students[i].Birthday},\nГруппа: {students[i].Group}, \nУспеваемость: {string.Join(", ", students[i].Progress)}");
//                    }
//                    break;

//                default:
//                    Console.WriteLine("Неправильный ввод");
//                    break;
//            }
//        }
//    }
//}



//zadanie 2

//using System;

//class Program
//{
//    static void Main()
//    {
//        const int n = 5;
//        Train[] trains = new Train[n];
//        int trainCount = 0;

//        while (true)
//        {
//            Console.Write("1 для добавления поезда, 2 для вывода всех поездов, для выхода из программы 0: ");
//            string a = Console.ReadLine()!;

//            switch (a)
//            {
//                case "0":
//                    Console.WriteLine("Завершение программы...");
//                    return;
//                case "1":
//                    if (trainCount >= n)
//                    {
//                        Console.WriteLine("Невозможно добавить больше поездов");
//                        break;
//                    }

//                    Train train = new Train();

//                    Console.Write("Введите название пункта назначения: ");
//                    string destination = Console.ReadLine()!;
//                    train.Destination = destination;

//                    Console.Write("Введите номер поезда: ");
//                    int num = Convert.ToInt32(Console.ReadLine()!);
//                    train.NumberTrain = num;

//                    Console.Write("Введите время отправления (15:00): ");
//                    DateTime time = Convert.ToDateTime(Console.ReadLine());
//                    train.DepartureTime = time;

//                    trains[trainCount] = train;
//                    trainCount++;
//                    break;

//                case "2":
//                    for (int i = 0; i < trainCount; i++)
//                    {
//                        Console.WriteLine($"Пункт назначения: {trains[i].Destination}\nНомер поезда: {trains[i].NumberTrain}\nВремя отправления: {trains[i].DepartureTime}");
//                    }
//                    break;

//                default:
//                    Console.WriteLine("Неправильный ввод");
//                    break;
//            }
//        }
//    }
//}



//zadanie 3
//using System;

//class Numbers
//{
//    public static int FirstNumber { get; set; }
//    public static int SecondNumber { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        while (true)
//        {
//            Console.Write("Для выхода из программы 0\n1 для добавления чисел\n2 для вывода всех чисел\n3 для суммы всех чисел\n4 для сравнения чисел: ");
//            string a = Console.ReadLine()!;

//            switch (a)
//            {
//                case "0":
//                    Console.WriteLine("Завершение программы...");
//                    return;
//                case "1":
//                    СhangeNum();
//                    break;
//                case "2":
//                    PrintNums();
//                    break;
//                case "3":
//                    SumNum();
//                    break;
//                case "4":
//                    LargestOfNumbers();
//                    break;

//                default:
//                    Console.WriteLine("Неправильный ввод");
//                    break;
//            }
//        }
//    }

//    static void PrintNums()
//    {
//        Console.WriteLine($"1 число: {Numbers.FirstNumber}\n2 число: {Numbers.SecondNumber}");
//    }
//    static void СhangeNum()
//    {
//        Console.Write("Введите 1 число: ");
//        int firstnum = Convert.ToInt32(Console.ReadLine());
//        Numbers.FirstNumber = firstnum;

//        Console.Write("Введите 2 число: ");
//        int secondnum = Convert.ToInt32(Console.ReadLine());
//        Numbers.SecondNumber = secondnum;
//    }
//    static void SumNum()
//    {
//        int sum = 0;
//        sum = Numbers.FirstNumber + Numbers.SecondNumber;
//        Console.WriteLine($"Сумма чисел: {sum}");
//    }
//    static void LargestOfNumbers()
//    {
//        if (Numbers.FirstNumber > Numbers.SecondNumber)
//        {
//            Console.WriteLine($"{Numbers.FirstNumber} > {Numbers.SecondNumber}");
//        }
//        else if (Numbers.FirstNumber < Numbers.SecondNumber)
//        {
//            Console.WriteLine($"{Numbers.FirstNumber} < {Numbers.SecondNumber}");
//        }
//        else
//        {
//            Console.WriteLine($"{Numbers.FirstNumber} = {Numbers.SecondNumber}");
//        }
//    }
//}



//zadanie 4
//using System;
//class Counter
//{
//    private int value;

//    public Counter()
//    {
//        value = 0;
//    }

//    public Counter(int initialValue)
//    {
//        value = initialValue;
//    }

//    public void Increment()
//    {
//        value++;
//    }

//    public void Decrement()
//    {
//        value--;
//    }

//    public int Value
//    {
//        get { return value; }
//    }
//}



//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите число: ");
//        int a = Convert.ToInt32(Console.ReadLine());

//        var myCounter = new Counter(a);

//        while (true)
//        {
//            Console.Write("\n0 для выхода из программы\n1 для увеличения\n2 для уменьшения\n3 для вывода: ");
//            int b = Convert.ToInt32(Console.ReadLine());
//            switch (b)
//            {
//                case 0:
//                    Console.WriteLine("Завершение программы...");
//                    return;
//                case 1:
//                    myCounter.Increment();
//                    break;
//                case 2:
//                    myCounter.Decrement();
//                    break;
//                case 3:
//                    Console.WriteLine($"Значение счетчика: {myCounter.Value}");
//                    break;
//                default:
//                    Console.WriteLine("Неправильный ввод");
//                    break;
//            }
//        }
//    }
//}



//zadanie 5
//using System;
//class Numbers
//{
//    // Свойства класса
//    private int FirstNumber { get; set; }
//    private int SecondNumber { get; set; }

//    // Конструктор, инициализирующий свойства по умолчанию
//    public Numbers()
//    {
//        FirstNumber = 0;
//        SecondNumber = 0;
//    }
//    // Конструктор с входными параметрами
//    public Numbers(int value1, int value2)
//    {
//        FirstNumber = value1;
//        SecondNumber = value2;
//    }



//    public int Value1
//    {
//        get { return FirstNumber; }
//        set { FirstNumber = value; }
//    }

//    public int Value2
//    {
//        get { return SecondNumber; }
//        set { SecondNumber = value; }
//    }
//    // Деструктор класса
//    ~Numbers()
//    {
//        Console.WriteLine("Объект был удален");
//    }

//}



//class Program
//{
//    static void Main()
//    {
//        var Object1 = new Numbers(5, 10);
//        Console.WriteLine($"1 объект: 1 значение = {Object1.Value1}, 2 значение = {Object1.Value2}");

//        var Object2 = new Numbers();
//        Console.WriteLine($"2 объект: 1 значение = {Object2.Value1}, 2 значение = {Object2.Value2}");

//        Object2.Value1 = 10;
//        Object2.Value2 = 15;

//        Console.WriteLine($"2 объект (после изменения): 1 значение = {Object2.Value1}, 2 значение = {Object2.Value2}");
//    }
//}
//***********************************************************************************************************



//****************************************Практическая 2.3***************************************************
//zadanie 1
//using System;
//using System.Linq;
//using System.Collections.Generic;
//class Worker
//{
//    public string Name { get; set; }
//    public string SurName { get; set; }
//    public int rate { get; set; }
//    public int days { get; set; }

//    public int GetSalary()
//    {
//        return rate * days;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Worker worker = new Worker();
//        List<Worker> works = new List<Worker>()
//        {
//            new Worker { Name = "Карен", SurName = "Акобян", rate = 1000, days = 365},
//            new Worker { Name = "Павел", SurName = "Федоров", rate = 1007, days = 278},
//            new Worker { Name = "Максим", SurName = "Войтенко", rate = 1009, days = 500}
//        };

//        foreach (var x in works)
//        {
//            int zarplata = x.GetSalary();
//            Console.WriteLine($"Имя = {x.Name}, Фамилия = {x.SurName}, Ставка = {x.rate}, Дни = {x.days}, Зарплата = {zarplata}");
//        }
//    }
//}



//zadanie 2
//using System;
//using System.Linq;
//using System.Collections.Generic;
//class Worker
//{
//    private string Name;
//    private string SurName;
//    private int Rate;
//    private int Days;
//    public string name
//    {
//        get { return Name; }
//        set { Name = value; }
//    }

//    public string surname
//    {
//        get { return SurName; }
//        set { SurName = value; }
//    }

//    public int rate
//    {
//        get { return Rate; }
//        set { Rate = value; }
//    }

//    public int days
//    {
//        get { return Days; }
//        set { Days = value; }
//    }

//    public int GetSalary()
//    {
//        return rate * days;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Worker worker = new Worker();
//        List<Worker> works = new List<Worker>()
//        {
//            new Worker { name = "Карен", surname = "Акобян", rate = 1000, days = 365},
//            new Worker { name = "Павел", surname = "Федоров", rate = 1007, days = 278},
//            new Worker { name = "Максим", surname = "Войтенко", rate = 1009, days = 500}
//        };

//        foreach (var x in works)
//        {
//            int zarplata = x.GetSalary();
//            Console.WriteLine($"Имя = {x.name}, Фамилия = {x.surname}, Ставка = {x.rate}, Дни = {x.days}, Зарплата = {zarplata}");
//        }
//    }
//}



//zadanie 3
//using System;

//public class Calculation
//{
//    private string calculationLine { get; set; }

//    public void SetCalculationLine(string line)
//    {
//        calculationLine = line;
//    }

//    public void SetLastSymbolCalculationLine(char symbol)
//    {
//        calculationLine += symbol;
//    }

//    public string GetCalculationLine()
//    {
//        return calculationLine;
//    }

//    public char GetLastSymbol()
//    {
//        if (calculationLine.Length > 0)
//        {
//            return calculationLine[calculationLine.Length - 1];
//        }
//        else
//        {
//            return '\0';
//        }
//    }

//    public void DeleteLastSymbol()
//    {
//        if (calculationLine.Length > 0)
//        {
//            calculationLine = calculationLine.Remove(calculationLine.Length - 1);
//        }
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        Calculation calc = new Calculation();
//        calc.SetCalculationLine("1234");
//        Console.WriteLine(calc.GetCalculationLine()); // Вывод: 1234
//        calc.SetLastSymbolCalculationLine('5');
//        Console.WriteLine(calc.GetCalculationLine()); // Вывод: 12345
//        Console.WriteLine(calc.GetLastSymbol()); // Вывод: 5
//        calc.DeleteLastSymbol();
//        Console.WriteLine(calc.GetCalculationLine()); // Вывод: 1234
//    }
//}
//***********************************************************************************************************



//****************************************Практическая 2.4***************************************************
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите римское число: ");
//        string nums = Console.ReadLine();
//        Console.WriteLine(RomanToDecimal(nums));
//    }

//    static int RomanToDecimal(string nums)
//    {
//        char[] romanChars = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
//        int[] decimalNums = { 1, 5, 10, 50, 100, 500, 1000 };
//        int result = 0;
//        int prev = 0;
//        int len = nums.Length;
//        for (int i = len - 1; i >= 0; i--)
//        {
//            char current = nums[i];
//            int value = 0;
//            for (int j = 0; j < 7; j++)
//            {
//                if (romanChars[j] == current)
//                {
//                    value = decimalNums[j];
//                    break;
//                }
//            }
//            result = value < prev ? result -= value : result += value;
//            prev = value;
//        }
//        return result;
//    }
//}
//***********************************************************************************************************



//****************************************Практическая 2.5***************************************************
//namespace GarageConsoleApp;

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        //***********************************************************
//        // Вывод тип машины (автобус, автомобиль и т.д.)
//        Console.WriteLine("Типы транспорта:");
//        DatabaseRequests.GetTypeCarQuery();
//        Console.WriteLine();

//        // Добавление типа машины
//        DatabaseRequests.AddTypeCarQuery("Воздушный");

//        // Вывод список типов машин
//        DatabaseRequests.GetTypeCarQuery();
//        Console.WriteLine();
//        //***********************************************************



//        //***********************************************************
//        // Вывод водителей
//        Console.WriteLine("Водители:");
//        DatabaseRequests.GetDriverQuery();
//        Console.WriteLine();

//        //Добавление водителя
//        //DatabaseRequests.AddDriverQuery("Денис", "Иванов", DateTime.Parse("1997.01.12"));

//        // Вывод водителей
//        Console.WriteLine("Водители с добавлением нового водителя :");
//        DatabaseRequests.GetDriverQuery();
//        Console.WriteLine();

//        // Добавление категории прав
//        //DatabaseRequests.AddRightsCategoryQuery("C");

//        // Добавление категории прав водителю   
//        //DatabaseRequests.AddDriverRightsCategoryQuery(8,2);

//        //Вывод водителя с категорией прав
//        DatabaseRequests.GetDriverRightsCategoryQuery(8);
//        Console.WriteLine();
//        //***********************************************************



//        //***********************************************************
//        //Вывод машин
//        Console.WriteLine("Машины:");
//        DatabaseRequests.GetCarQuery();
//        Console.WriteLine();

//        //Добавление машин
//        DatabaseRequests.AddCarQuery(4, "Жи32апыгулдь", "О381ОО70", 68);

//        //Вывод машин
//        Console.WriteLine("Вывод машин с добавлением новой машины:");
//        DatabaseRequests.GetCarQuery();
//        Console.WriteLine();
//        //***********************************************************



//        //***********************************************************
//        //Вывод маршрутов #Томск-Новосибирск
//        Console.WriteLine("Маршруты:");
//        DatabaseRequests.GetItineraryQuery();
//        Console.WriteLine();

//        //Добавление маршрутов
//        DatabaseRequests.AddItineraryQuery("Новосибирск-Москва");

//        //Вывод маршрутов
//        Console.WriteLine("Вывод маршрутов с добавлением нового маршрута:");
//        DatabaseRequests.GetItineraryQuery();
//        Console.WriteLine();
//        //***********************************************************



//        //***********************************************************
//        //Вывод рейсов 
//        Console.WriteLine("Рейсы:");
//        DatabaseRequests.GetRouteQuery();
//        Console.WriteLine();

//        //Добавление рейсов
//        DatabaseRequests.AddRouteQuery(3, 2, 4, 5);

//        //Вывод рейсов
//        Console.WriteLine("Вывод рейсов с добавлением нового рейса:");
//        DatabaseRequests.GetRouteQuery();
//        //***********************************************************
//    }
//}
//***********************************************************************************************************



//****************************************Практическая 2.6***************************************************
//using System;
//using System.Net;
//using Newtonsoft.Json;

//class Program
//{
//    static void Main(string[] args)
//    {
//        string city = "Томск";
//        string apiKey = "464288fc57f6e5ae822d7725315f0f2e"; //API-ключ

//        using (WebClient client = new WebClient())
//        {
//            string url = $"http://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&lang=ru&appid={apiKey}";
//            try
//            {
//                string json = client.DownloadString(url); // загрузка JSON-ответа

//                WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(json); // десериализация JSON-данных
//                Console.WriteLine($"Температура в {weatherData.name}: {weatherData.main.temp} °C, Ощущается как: {weatherData.main.feels_like}");
//                Console.WriteLine($"Погода в {weatherData.name}: {weatherData.weather[0].main}, Описание: {weatherData.weather[0].description}");
//                Console.WriteLine($"Скорость ветра в {weatherData.name}: {weatherData.wind.speed}");
//            }
//            catch (WebException ex)
//            {
//                Console.WriteLine("Ошибка при загрузке данных:");
//                Console.WriteLine(ex.Message);
//            }
//        }
//    }
//}
//class WeatherData
//{
//    public Weather[] weather { get; set; }
//    public Weather main { get; set; }
//    public string name { get; set; }
//    public Weather wind { get; set; }
//}

//class Weather
//{
//    public string main { get; set; }
//    public float temp { get; set; }
//    public string description { get; set; }
//    public float speed { get; set; }
//    public float feels_like { get; set; }
//}
//***********************************************************************************************************
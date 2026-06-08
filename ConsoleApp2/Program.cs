//промт для проверки
//   оцени мое решение "" на задание "" предложенное решение ""




//страница 130


Person first = new Person("Боб", 19);
Person second = new Person("Боб", 19);

Console.WriteLine($"{first} == {second}: {first == second}");

second = second with { Name = "Дилан" };

Console.WriteLine($"{first} == {second}: {first == second}");

Point obj1 = new Point(1, 2);
Point obj2 = obj1;
Console.WriteLine( $"{obj1} == {obj2} : {obj1 == obj2}" );

obj2 = obj2 with { Y = 3 };
Console.WriteLine($"{obj1} == {obj2} : {obj1 == obj2}" );

record Person(string Name, int  Age);
record struct Point (int X, int Y);



//



//страница 125
/*
Tuple<string, string, int> book = new Tuple<string, string, int>("Преступление " +
                                                                 "и наказание", "Достоевский", 1884);
Console.WriteLine($"{book.Item1}, {book.Item2}, {book.Item3}");

(string nameof, string author, int year) book2 = ("Преступление и наказание", 
    "Достоевский", 1884);

Console.WriteLine($"{book2.nameof}, {book2.author}, {book2.year}");

List<(string Title, string Author, int Year)> books =
[
    ("Преступление и наказание", "Фёдор Достоевский", 1866),
    ("Война и мир", "Лев Толстой", 1869),
    ("1984", "Джордж Оруэлл", 1949),
    ("Дюна", "Фрэнк Герберт", 1965),
    ("Мастер и Маргарита", "Михаил Булгаков", 1967),
    ("Гарри Поттер и философский камень", "Дж. К. Роулинг", 1997)
];

(string oldest, string newest, double med) = find(books);
Console.WriteLine($"{oldest}, {newest}, {med}");

List<(string Genre, int Year)> testData =
[
    ("фантастика", 1985), 
    ("фантастика", 1980), 
    ("фантастика", 1960), 
    ("детектив", 2005), 
    ("детектив", 1990), 
    ("детектив", 1950), 
    ("романтика", 2023), 
    ("история", 1900) 
];

foreach (var item in testData)
{
    Console.WriteLine(ClassifyBook(item.Genre, item.Year));
}

static (string Oldest, string Newest, double AvgYear) find(List<(string Title, 
    string Author, int Year)> li)
{
    double sum = 0;
    (string T1, string A1, int Y1) oldest, newest;
    oldest = li[0];
    newest = li[0];
    foreach (var item in li)
    {
        (_, _, int year) = item;
        sum += year;
        
        if (year > newest.Y1)
        {
            newest = item;
        }
        else if (year < oldest.Y1)
        {
            oldest = item;
        }
    }
    
    double med = sum / li.Count;
    return (oldest.T1, newest.T1, med);
}

static string ClassifyBook(string genre, int year) =>
    (genre, year) switch
    {
        ("фантастика", > 1980) => "современная фантастика",
        ("фантастика", <= 1980) => "классическая фантастика",
        ("детектив", > 1990) => "современный детектив",
        ("детектив", <= 1990) => "классический детектив",
        _ => "другие жанры"
    };
*/
//



//страница 117
/*
List<string> names_of_student = ["А", "Б", "В", "Г", "Д"];
foreach (string name in names_of_student)
{
    Console.WriteLine($"{name}");
}

string new_student = "Е", remove_student = "Б";
names_of_student.Add("Е");

string find = "А";

bool res = names_of_student.Contains(find);

if (res)
{
    Console.WriteLine($"студент {find} существует");
}
else
{
    Console.WriteLine($"Студента {find} нет");
}

names_of_student.Remove(remove_student);

int n = 0;
foreach (string name in names_of_student)
{
    ++n;
    Console.WriteLine($"{n} - {name}");
}

Stack<string> students = new Stack<string>();
students.Push("А");
students.Push("Б");
students.Push("В");

Console.WriteLine($"последний сдавший экзамен - {students.Peek()}");

while (students.Count > 0)
{
    Console.WriteLine(students.Pop());
}

Queue<string> studentsQueue = new Queue<string>();
studentsQueue.Enqueue("А");
studentsQueue.Enqueue("Б");
studentsQueue.Enqueue("В");
studentsQueue.Enqueue("Г");

Console.WriteLine($"Первый в очереди - {studentsQueue.Peek()}");

while (studentsQueue.Count > 0)
{
    Console.WriteLine(studentsQueue.Dequeue());
}

Dictionary<string, int> studentsDictionary = new Dictionary<string, int>()
{
    ["А"] = 4,
    ["Б"] = 3,
    ["В"] = 3,
    ["Г"] = 5,
    ["Д"] = 2,
};

double sum = 0;

foreach (var (s, m) in studentsDictionary)
{
    sum += m;
    Console.WriteLine($"{s} - {m}");
}

string sname = "А";
studentsDictionary.TryGetValue(sname, out var value);

Console.WriteLine($"Оценка студента {sname} - {value}");

double med = sum / studentsDictionary.Count;

Console.WriteLine($"Средняя оценка группы - {med}");
*/



//



//страница 102
/*
using System.Globalization;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

switch (args[0].ToLower())
{
    case "generate":
        Generate();
        break;
    case "filter":
        Filter();
        break;
    default:
        Console.Error.WriteLine($"{args[0]} - неизвестно что");
        break;
}

void Generate()
{
    string[] param = { "Фамилия", "Предмет", "Оценка" };
    string[] secnames = { "А", "Б", "В", "Г", "Д" };
    string[] school = { "Физика", "Математика", "Информатика" };

    Random rng = new(1);

    for (int i = 0; i < 20; ++i)
    {
        int mark = rng.Next(2, 6);
        string sch =  school[rng.Next(school.Length)];
        string secn = secnames[rng.Next(secnames.Length)];
        Console.WriteLine($"{secn};{sch};{mark}");
    }

    Console.Error.WriteLine("Поставлено 20 оценок");

}

void Filter ()
{
    if (!int.TryParse(args[1],  out int thresold) || thresold > 5)
    {
        Console.Error.WriteLine("Неккоректный ввод. Введите число не превосходящее 5");
    } 
    else
    {
        string? line;
        while ((line = Console.ReadLine()) is not null)
        {
            string[] lines = line.Split(";");
            if (lines.Length != 3 || !int.TryParse(lines[2], out int mark))
            {
                Console.Error.WriteLine($"[Filter] Кривая строка {line}");
                continue;
            }
            
            if (mark >= thresold)
            {
                Console.WriteLine(line);
            }
            else
            {
                Console.Error.WriteLine($"Оценка в строке {line} не проходит " +
                    $"порог {thresold}");
            }
        }
    }
}
*/


//
















//страница 91
/*
using System.Text;

string choice = "", pathFile = Path.Combine(AppContext.BaseDirectory, "list.txt");

if (!File.Exists(pathFile))
{
    Console.WriteLine("Создан файл для записи");
    File.WriteAllText(pathFile, "");
}

while (choice != "2")
{
    Console.WriteLine($"1 - введите несколько строк до ввода пустой строки\n2 - " +
        $"вывод файла и завершение программы");
    choice =  Console.ReadLine();
    switch(choice)
    {
        case "1":
            add_to_list(pathFile);
            break;
        case "2":
            print_file(pathFile);
            break;
        default: 
            Console.WriteLine("Неправильный ввод");
            break;
    }
}

void add_to_list(string path)
{
    int number = 1;
    StringBuilder sb = new StringBuilder();
    string line = Console.ReadLine();
    while (line != "")
    {
        sb.AppendLine($"{number} [{DateTime.Now:dd.MM.yyyy}] {line}");
        number++;
        line = Console.ReadLine();
    }

    File.WriteAllText(path, sb.ToString());
}

void print_file(string path)
{
    foreach (var line in File.ReadLines(path))
    {
        Console.WriteLine(line.ToString());
    }
    
    Console.WriteLine("Конец вывода");
}
*/
//









////страница 79
//string sourceFile = Path.Combine(AppContext.BaseDirectory, "notes.txt");
//if (!File.Exists(sourceFile))
//{
//    Console.WriteLine("Файл заметок не найден, будет создан новый");
//    File.WriteAllText(sourceFile, "");
//}

//string? n="";

//while (n!="0")
//{
//    Console.WriteLine("Меню для заметки notes.txt\n Выберите пункт:\n" +
//        "1 - Добавить заметку\n2 - Показать все заметки\n3 - Найти заметку по слову" +
//        "\n4 - Очистить все заметки\n0 - Выход");
//    n = Console.ReadLine();
//    switch(n)
//    {
//        case "1":
//            addnote(sourceFile);
//            break;
//        case "2":
//            showallnotes(sourceFile);
//            break;
//        case "3":
//            findnote(sourceFile);
//            break;
//        case "4":
//            cleannotes(sourceFile);
//            break;
//        case "0":
//            Console.WriteLine($"{sourceFile}");
//            break;
//        default:
//            Console.WriteLine("Неправильный ввод");
//            break;
//    }
//}


//void addnote (string path)
//{
//    Console.WriteLine("Введите текст заметки:");
//    string time = DateTime.Now.ToString("[dd.MM.yyyy HH:mm]");
//    string str = $"\n{time} {Console.ReadLine()}";
//    File.AppendAllText(path, str);
//}

//void showallnotes(string path)
//{
//    foreach (string str in File.ReadLines(path))
//    {
//        Console.WriteLine(str);
//    }
//}

//void findnote(string path)
//{
//    Console.WriteLine("введите слово для поиска");
//    string find = Console.ReadLine();
//    int n = 1;
//    foreach (string str in File.ReadLines(path))
//    {
//        if (str.Contains(find))
//        {
//            Console.WriteLine($"{n} {str}\n");
//        }
//        ++n;
//    }
//}

//void cleannotes(string path)
//{
//    File.WriteAllText(path, "");
//    Console.WriteLine("Все стерто");
//}

//конец






//// страница 68
//Console.Write("Введите каталог: ");
//string? path = Console.ReadLine();
//while (!Directory.Exists(path))
//{
//    Console.WriteLine($"Каталога {path} не существует\nВведите путь к файлу: ");
//    path = Console.ReadLine();
//}
//Console.WriteLine($"Файл {path} существует");

//int n = processing_files(path);
//Console.WriteLine($"Итоговое количество найденных файлов: {n}");

//int processing_files (string? path)
//{
//    string[] files = Directory.GetFiles(path, "*.txt", 
//                            SearchOption.AllDirectories);
//    foreach (string file  in files)
//    {
//        Console.WriteLine($"{Path.GetFileName(file)}\nДата последнего " +
//            $"изменения: {File.GetLastWriteTime(file):dd.MM.yyyy HH:mm}" +
//            $"\nПуть: {Path.GetDirectoryName(file)}");
//    }
//    return files.Length;

//}


////конец








////56 страница

//int?[] numbers = { -10, null, 25, null,
//                 30, 15, null };

//Console.WriteLine("Вывести исходный массив (для null выводить слово null)");
//foreach(int?  number in numbers)
//{
//    if (number ==  null)
//    {
//        Console.Write("null ");
//    }
//    else
//    {
//        Console.Write($"{number} ");
//    }
//}

//Console.WriteLine("\nПодсчитать количество null-значений, используя проверку is null");
//int nul = 0;
//foreach (int? number in numbers)
//{
//    if (number is null)
//    {
//        nul++;
//    }
//}

//Console.WriteLine($"количество null in array {nul}");

//Console.WriteLine("\nПодсчитать количество не null-значений, используя проверку is null");
//nul = 0;
//foreach (int? number in numbers)
//{
//    if (number is not null)
//    {
//        nul++;
//    }
//}

//Console.WriteLine($"количество not null in array {nul}");

//Console.WriteLine("Вычислить сумму всех ненулевых чисел, используя свойство HasValue и Value");
//nul = 0;
//foreach (int? number in numbers)
//{
//    if (number.HasValue)
//    {
//        if (number.Value > 0)
//        {
//            nul+=number.Value;
//        }
//    }
//}

//Console.Write($"сумма ненулевых {nul}\n");

//Console.WriteLine("\nСоздать новый массив, где все null заменены на -1,используя оператор ??");

//int?[] newarr = new int?[numbers.Length];

//for (int i = 0; i < numbers.Length; i++)
//{
//    newarr[i] = numbers[i] ?? -1;
//    Console.Write($"{newarr[i]} ");

//}

//Console.WriteLine("\nВывести длину строкового представления каждого числа (используя оператор ?. для вызова метода " +
//    "ToString())");

//for (int i = 0; i < numbers.Length; i++)
//{
//    int? a = (numbers[i])?.ToString()?.Length;
//    int b = a == null ? 0 : (int)a;
//    Console.Write($"{b} ");
//}

//Console.WriteLine("\n\nЗаменить все null-значения в исходном массиве на 0,используя оператор ??=");
//for (int i = 0; i < numbers.Length; ++i)
//{
//    numbers[i] ??= 0;
//    Console.Write($"{numbers[i]} ");
//}











//51 страница
//int[,] matrix1 = {
//{ 1, 2, 3 },
//{ 2, 5, 6 },
//{ 3, 6, 9 }
//};
//Console.Write($"Is symmetric: {Is_Symmetric(matrix1)}\nMatrix:\n");
//Print_matrix(matrix1);


//bool Is_Symmetric(int[,] arr)
//{
//    if (arr.GetLength(0) != arr.GetLength(0))
//    {
//        return false;
//    }
//    else
//    {
//        for (int i = 0; i < arr.GetLength(0); i++)
//        {
//            for (int j = 0; j < arr.GetLength(1); j++)
//            {
//                if (i == j)
//                {
//                    continue;
//                }
//                else
//                {
//                    if (arr[i,j] == arr[j,i])
//                    {
//                        continue;
//                    }
//                    else
//                    {
//                        return false;
//                    }
//                }
//            }
//        }
//    }
//    return true;   
//}

//void Print_matrix(int[,] arr)
//{
//    for (int i = 0; i < arr.GetLength(0); i++)
//    {
//        for (int j = 0; j < arr.GetLength(1); j++)
//        {
//            Console.Write($"{arr[i, j]} ");
//        }
//        Console.Write('\n');
//    }
//}









//45 страница
//int[] numbers = { 5, -3, 8, 12, -7, 0, 15, -2, 4, 20 };
//PrintEvenIndices(numbers);
//Console.WriteLine("Проверка PrintEvenIndices");
//Console.WriteLine($"{CalculateSum(numbers)}");
//Console.WriteLine("Проверка CalculateSum");
//Console.WriteLine($"{FindFirstGreaterThan(10, numbers)}");
//Console.WriteLine("Проверка FindFisrtGreaterthan");
//PrintUntilSumExceeds(10, numbers);
//Console.WriteLine("Проверка PrintUntilSumexceeds");
//PrintPositiveOnly(numbers);
//Console.WriteLine("Проверка PrintPositiveOnly");

//void PrintEvenIndices(int[] array)
//{
//    for (int i = 0; i < array.Length; i += 2)
//    {
//        Console.WriteLine(numbers[i]);
//    }

//}

//int CalculateSum(int[] numbers)
//{
//    int sum = 0;
//    foreach (int i in numbers)
//    {
//        sum += i;
//    }
//    return sum;
//}

//int FindFirstGreaterThan(int Great, int[] numbers)
//{
//    foreach (int i in numbers)
//    {
//        if (i > Great)
//        {
//            return i;
//        }
//    }
//    return 0;
//}

//void PrintUntilSumExceeds(int param, int[] numbers)
//{
//    int sum = 0, i = 0;
//    do
//    {
//        sum += numbers[i++];
//        Console.WriteLine($"элемент {i} накопленная сумма {sum}");
//    } while (sum <= param && i < numbers.Length);
//}

//void PrintPositiveOnly(int[] numbers)
//{
//    foreach (int i in numbers)
//    {
//        if (i <= 0)
//        {
//            continue;
//        }
//        else
//        {
//            Console.WriteLine(i);
//        }
//    }
//}








//41 страница 
//object[] data = { 15, "Hello", -5, null, "World", 42, 0, "C#", -10 };

//AnalyzeWithIf(data);
//Console.WriteLine("\n Проверка analyzewithif завершена");
//AnalyzeWithSwitch(data);
//Console.WriteLine("\nПроверка analyzewithswitch завершена");
//GetCategory(data);
//Console.WriteLine("\nПроверка GetCategory завершена");

//void AnalyzeWithIf(object[] data)
//{
//    foreach (var item in data)
//    {
//        if (item is int i)
//        {
//            if (i > 0)
//            {
//                Console.WriteLine($"Положительное число: {i}");
//            }
//            else if (i == 0)
//            {
//                Console.WriteLine($"Ноль: {i}");
//            }
//            else
//            {
//                Console.WriteLine($"Отрицательное число: {i}");
//            }
//        }
//        else if (item is string s)
//        {
//            Console.WriteLine($"Строка: {s}");
//        }
//        else if (item is null)
//        {
//            Console.WriteLine("Пустое значение ");
//        }
//    }
//}

//void AnalyzeWithSwitch(object[] data)
//{
//    foreach (var item in data)
//    {
//        switch (item)
//        {
//            case int i when i > 0:
//                Console.WriteLine($"Положительное число: {i}");
//                break;
//            case int i when i == 0:
//                Console.WriteLine($"Ноль: {i}");
//                break;
//            case int i when i < 0:
//                Console.WriteLine($"Отрицательное число: {i}");
//                break;
//            case string s:
//                Console.WriteLine($"Строка: {s}");
//                break;
//            case null:
//                Console.WriteLine("Пустое значение");
//                break;
//        }
//    }
//}

//void GetCategory(object[] data)
//{
//    foreach (var item in data)
//    {
//        string result = item switch
//        {
//            int i and > 0 => "Положительное число: " + i,
//            int i and 0 => "Ноль: " + i,
//            int i and < 0 => "Отрицательное число: " + i,
//            string str => $"Строка: {str} ",
//            null => "Пустое значение",
//            _ => "Херная",
//        };
//        Console.WriteLine(result);
//    }
//}
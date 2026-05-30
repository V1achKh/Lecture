//страница 91
int number = 1;
string str, choice = "", pathFile = Path.Combine(AppContext.BaseDirectory, "list.txt");

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
            str = Console.ReadLine();
            add_to_list(str);
            break;
        case "2":
            print_file();
            break;
        default: 
            Console.WriteLine("Неправильный ввод");
            break;
    }
}

void add_to_list(string path)
{
    using StreamReader file = new StreamReader(path);

}

void print_file()
{

}

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
///

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
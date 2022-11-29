Console.Clear();
restart:
Console.WriteLine("1-4 Задачи семинара");
Console.WriteLine("5-7 Практические задачи");
Console.WriteLine("8 Дополнительная задача \n");
Console.Write("Что бы запустить какую то конкретную задау введите номер этой задачи то 1 до 8: ");
int Task = int.Parse(Console.ReadLine());

switch(Task){
    case 1:
    /*Задача 17: напишите программу, которая принимает на вход
     координаты точки (X и Y), причем X != 0 и Y != 0 и выдает 
     номер четверти плоскости в которой находится эта точка*/
    System.Console.WriteLine("Введите координату X: ");
    double x = double.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите координату Y: ");
    double y = double.Parse(Console.ReadLine());
    if (x > 0 && y > 0) Console.Write("1 четверть");
    else if (x < 0 && y > 0) Console.Write("2 четверть");
    else if (x < 0 && y < 0) Console.Write("3 четверть");
    else if (x > 0 && y > 0) Console.Write("4 четветь");
    else Console.Write("точка находится в нулевых координатах");
    break;

    case 2:
    /*Задача 18: Напишите программу, которая по заданному номеру
     четверти, показывае диапазон возможных координат точев к
     этой четвети (x и y)*/
    Console.Write("Введите номер четверти: ");
    int n = int.Parse(Console.ReadLine());
    if (n == 1) Console.WriteLine("x > 0 & y > 0"); 
    else if (n == 2) Console.WriteLine("x < 0 & y > 0"); 
    else if (n == 3) Console.WriteLine("x < 0 & y < 0"); 
    else Console.WriteLine("x > 0 & y < 0"); 
    break;

    case 3:
    /*Задача 21: Напишите программу, которая принмает на вход
     координаты двух точек и находит расстояние между ними в 2D
     пространстве*/
    System.Console.WriteLine("Введите координату X1: ");
    double x1 = double.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите координату Y1: ");
    double y1 = double.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите координату X2: ");
    double x2 = double.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите координату Y2: ");
    double y2 = double.Parse(Console.ReadLine());

    double result = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2));
    System.Console.WriteLine($"A({x1},{y1}); B({x2},{y2}) -> {Math.Abs(result)}");
    break;

    case 4:
    /*Задача 22: Напишите программу которая принимает на вход
     число (N) и выдаёт таблицу квадратов числе от 1 дj N*/
    Console.Write("Введите число: ");
    int N = int.Parse(Console.ReadLine());
    Console.Write($"{N} -> ");
    for (int i = 1; i < N+1; i++){
        Console.Write($"{i * i}  ");
    }
    break;

    /*Домашнее задание*/
    case 5:
    /*Задача 19: Напишите программу, которая принимает на вход
     пятизначное число и проверяет, является ли оно палиндромом*/
    Console.Write("Введите пятизначное число: ");
    int value = int.Parse(Console.ReadLine());
    int one = (value / 10000) % 10;
    int two = (value / 1000) % 10;
    //int three = (value / 100) % 10;
    int four = (value / 10) % 10;
    int five = value % 10;
       //Console.Write($"{one}, {two}, {three}, {four}, {five}");
    if (one == five && two == four) Console.Write($"{value} -> Да");
    else Console.Write($"{value} -> Нет");
    break;

    case 6: 
    /*Задача 21: Напишите программу, которая принимает на вход
     координаты двух точек и находит расстояние между ними в 3D*/
    System.Console.WriteLine("Введите координату X1: ");
     x1 = double.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите координату Y1: ");
     y1 = double.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите координату Z1: ");
     double z1 = double.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите координату X2: ");
     x2 = double.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите координату Y2: ");
     y2 = double.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите координату Z2: ");
     double z2 = double.Parse(Console.ReadLine());

    result = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2) + Math.Pow(z1-z2,2));
    System.Console.WriteLine($"A({x1},{y1},{z1}); B({x2},{y2},{z2}) -> {Math.Abs(result)}");
    break;

    case 7: 
    /*Задача 23: напишите программу, которая принимает на вход число
    N и выдает табоицу кубов чисел от 1 до N*/
    Console.Write("Введите число: ");
    int N1 = int.Parse(Console.ReadLine());
    Console.Write($"{N1} -> ");
    for (int i = 1; i < N1+1; i++){
        Console.Write($"{Math.Pow(i,3)}  ");
    }
    break;

    case 8:
    /*  Количество элементов в массиве от 3 до 1000
        Количество  не более 1000

    Массивы расположены по кругу. Каждый имеет 2 соседних.

    Найти максимально возможную сумму элементов
    из трех рядом стоящих массивов.*/

    start:
    //Создание кустов черники
    Console.Write("Введите количество кустов черники: ");
    int[] blueberries = new int [int.Parse(Console.ReadLine())];
    if (blueberries.Length < 3 || blueberries.Length > 1000){
        Console.WriteLine("Введите число от 3 до 1000");
        goto start;
    }
    //создание ягод на кустах черники
    for (int i=0; i < blueberries.Length; i++){
        blueberries[i] = new Random().Next(0, 1001);
        Console.Write($"{blueberries[i]} ");
    }
    Console.WriteLine();

    //Поиск максимального числа ягод, которое можно собрать за один заход
    int max = 0;
    int current = 0;
    for (int i = 0; i < blueberries.Length; i++){
        current =   blueberries[i % blueberries.Length] +
                    blueberries[(i+1) % blueberries.Length] + 
                    blueberries[(i+2) % blueberries.Length];
        if (current > max){
            max = current;
        }
    }
    Console.Write($"Максимального числа ягод, которое может \nсобрать за один заход собирающий модуль: {max}");
    break;

    default:
    goto restart;
}
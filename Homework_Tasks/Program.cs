/*
Урок 9.  Как не нужно писать код. Часть 3
*/

// Библиотека функций для выполнения вспомогательных операций.
//
// Организация завершения работы с модулем
bool CheckExit(dynamic num)
{
    if (num == 0)
    {
        Console.WriteLine("\nРабота с программой завершена, До встречи!\n");
        return true;
    }
    return false;
}

// // Создание 1D-массива заполненных случайно сгенерированными целыми числами
// int[] CreatRandom1DArray(int size, int minRnd, int maxRnd)
// {
//     int[] randNumber = new int[size];
//     Random int_rnd = new Random();
//     int i;
//     for (i = 0; i < size; i++)
//         randNumber[i] = int_rnd.Next(minRnd, maxRnd + 1);
//     return randNumber;
// }

// // Создание 2D-массива заполненных случайно сгенерированными числами (целыми или вещественными, на выбор)
// dynamic[,] CreatRandom2DArray(bool real = false, bool fill = true, bool zero = false)
// {
//     Console.Write("Введите число строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите число столбцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());

//     dynamic[,] newArray = new dynamic[rows, columns];

//     int minValue = 0; int maxValue = 0;
//     if (fill)
//     {
//         Console.Write("Введите минимальное значение элемента: ");
//         minValue = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Введите максимальное значение элемента: ");
//         maxValue = Convert.ToInt32(Console.ReadLine());

//         for (int i = 0; i < rows; i++)
//             for (int j = 0; j < columns; j++)
//                 newArray[i, j] = !real ? new Random().Next(minValue, maxValue + 1) :
//                                         minValue + (maxValue - minValue + 1) * new Random().NextDouble();
//     }
//     else if (zero)
//         for (int i = 0; i < rows; i++) for (int j = 0; j < columns; j++) newArray[i, j] = 0;

//     Console.WriteLine("");
//     return newArray;
// }

// // Вывод содержимого 1D-массива
// void Show1dArray(dynamic[] array, string text = "")
// {
//     if (text != string.Empty) Console.WriteLine(text);

//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//         Console.Write($"{array[i]} ");
//     Console.WriteLine("]\n");
// }

// // Вывод содержимого 2D-массива
// void Show2dArray(dynamic[,] array, string text = "", string markRow = "", int row = 0)
// {
//     if (text != string.Empty) Console.WriteLine(text);

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j]} ");
//         if (i == row) Console.Write($" {markRow}");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


/*-----------------------------------------------------------------
Задача 64: Задайте значения M и N. Напишите программу, которая 
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
-------------------------------------------------------------------
*/
void ShowNumbersRange(int M, int N)
{
    if (M != N) ShowNumbersRange(M, N + (M < N ? -1 : 1) );
    Console.Write($"{N} ");
}

// Основное тело программы.
Console.WriteLine(@"Задача-64. Вывод натуральных чисел в промежутке от M до N методом рекурсии");
Console.WriteLine("---");

while (true)
{
    Console.Write("Продолжить (1- ДА, 0 - НЕТ): ");
    if (CheckExit(Convert.ToInt16(Console.ReadLine()))) break;

    Console.Write("М: ");
    int M = Convert.ToInt16(Console.ReadLine());
    Console.Write("N: ");
    int N = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine("Результат:");
    ShowNumbersRange(M, N);
    Console.WriteLine("\n");
}
// *** Конец Задачи 64 ***


/*-------------------------------------------------------------------
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
---------------------------------------------------------------------
*/
int SummNumberRange(int M, int N)
{
    int dN =  (M < N ? -1 : 1);
    if (M != N) return N + SummNumberRange(M, N + dN);
    else        return N;
}

// Основное тело программы.
Console.WriteLine(@"Задача-66. Расчет и вывод суммы натуральных чисел от M до N методом рекурсии");
Console.WriteLine("---");

while (true)
{
    Console.Write("Продолжить (1- ДА, 0 - НЕТ): ");
    if (CheckExit(Convert.ToInt16(Console.ReadLine()))) break;

    Console.Write("М: ");
    int M = Convert.ToInt16(Console.ReadLine());
    Console.Write("N: ");
    int N = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine($"Результат расчета -> {SummNumberRange(M, N)}");
}
// *** Конец Задачи 66 ***


/*-------------------------------------------------------------------
Задача 68: Напишите программу вычисления 
функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m, n) = 29
A(0, n) = n + 1
A(m, 0) = A(m - 1, 1)
A(m, n) = A(m - 1, A(m, n -1)) 
---------------------------------------------------------------------
*/
int AkkermanFunction(int m, int n, int count = 0)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AkkermanFunction(m - 1, 1, count);
    else return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1, count), count);
}

// Основное тело программы.
Console.WriteLine(@"Задача-68. Вычисление функции Аккермана методом рекурсии");
Console.WriteLine("---");

while (true)
{
    Console.Write("\nПродолжить (1- ДА, 0 - НЕТ): ");
    if (CheckExit(Convert.ToInt16(Console.ReadLine()))) break;

    int N = 3; int M = 11;

    Console.Write("\nm / n ");
    for (int j = 0; j < M + 1; j++) Console.Write($"{String.Format("{0,7:0}", j)}");
    Console.WriteLine("\n------------------------------------------------------------------------------------------");

    for (int i = 0; i < N + 1; i++)
    {
        Console.Write($"m = {i}:");
        for (int j = 0; j < M + 1; j++) Console.Write($"{String.Format("{0,7:0}", AkkermanFunction(i, j))}");
        Console.WriteLine();
    }
}
// *** Конец Задачи 68 ***

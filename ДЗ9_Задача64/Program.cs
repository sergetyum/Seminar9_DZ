// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Write("Задайте значение числа N: ");
int number = int.Parse(Console.ReadLine());
int numbercurrent = number - 1;

if (number < 1) Console.Write($"Число {number} не является натуральным.");
if (number == 1) Console.Write($"N={number} -> \"{number}\"");
if (number > 1)
{
    void PrintReqursive(int numbercurrent)
    {
        Console.Write($", ");
        Console.Write(numbercurrent);
        numbercurrent--; //numbercurrent = numbercurrent - 1;
        if (numbercurrent > 0) PrintReqursive(numbercurrent);
    }
    Console.Write($"N={number} -> \"{number}");
    PrintReqursive(numbercurrent);
    Console.Write($"\"");
}
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Write("Задайте значение числа M: ");
int numberM = int.Parse(Console.ReadLine());
Console.Write("Задайте значение числа N: ");
int numberN = int.Parse(Console.ReadLine());

if (numberM < 1 || numberN < 1) Console.Write("Оба числа должны быть натуральными.");
else if (numberM >= numberN) Console.Write("Число M должно быть меньше числа N.");
else
{
    int summaOfNaturalElements = 0;
    static int SummaOfNaturalElementsRecursive(int numberM, int numberN, int summaOfNaturalElements)
    {
        summaOfNaturalElements = summaOfNaturalElements + numberM;
        numberM++;
        if (numberM <= numberN) SummaOfNaturalElementsRecursive(numberM, numberN, summaOfNaturalElements);
        else
        {
            Console.Write($"Сумма натуральных чисел в промежутке от M до N равна: {summaOfNaturalElements}");
        }
        return summaOfNaturalElements;
    }
    SummaOfNaturalElementsRecursive(numberM, numberN, summaOfNaturalElements);
}
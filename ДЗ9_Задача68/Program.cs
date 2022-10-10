// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Задайте целое неотрицательное значение числа m: ");
int numberM = int.Parse(Console.ReadLine());
Console.Write("Задайте целое неотрицательное значение числа n: ");
int numberN = int.Parse(Console.ReadLine());

if (numberM < 0 || numberN < 0) Console.Write("Числа должны быть неотрицательными.");
else
{
    // Функция Аккермана определяется следующим образом:
    // A(m,n)=n+1, при m=0,
    // A(m,n)=A(m−1,1), при m>0, n=0,
    // A(m,n)=A(m−1,A(m,n−1)), при m>0, n>0.

    int CalculatingTheAckermanFunction(int numberM, int numberN)
    {
        if (numberM == 0) return numberN + 1;
        if (numberM > 0 && numberN == 0) return CalculatingTheAckermanFunction(numberM - 1, 1);
        if (numberM > 0 && numberN > 0) return CalculatingTheAckermanFunction(numberM - 1, CalculatingTheAckermanFunction(numberM, numberN - 1));
        return CalculatingTheAckermanFunction(numberM, numberN);
    }
    Console.Write($"m={numberM}, n={numberN} => A(m,n) = {CalculatingTheAckermanFunction(numberM, numberN)}");
}
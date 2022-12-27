/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */


Console.Write("Введите M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine()!);

int Natural(int a, int b)
{
    if (a == b)
    {
        return a;
    }
    else if (a < b)
    {
        return (a + Natural(a+1, b));
    }

    else
    {
        return (b + Natural(b+1, a));
    }
}
Console.WriteLine($"Сумма натуральных чисел в промежутке от {M} до {N}:");
Console.WriteLine(Natural(M, N));
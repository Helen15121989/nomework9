/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
GetSumm(m, n, 0);


void GetSumm(int m, int n, int sum)
{

    if (m > n)
    {
        Console.WriteLine("Cумма элементов: " + sum);
        return;
    }
    sum = sum + (m++);

    GetSumm(m, n, sum);
}

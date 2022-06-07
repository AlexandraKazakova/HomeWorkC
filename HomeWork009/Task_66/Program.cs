// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите M -> ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите N -> ");
int n = int.Parse(Console.ReadLine());

int SumNumbers(int a, int b)
{
	return a == b + 1 ? 0 : SumNumbers(a + 1, b) + a;
}
Console.WriteLine(SumNumbers(m, n));

// int sum = 0;
// int SumNumbers(int a, int b)
// {
// 	if (a <= b)
// 	{
// 		SumNumbers(a + 1,b);
// 		sum += a;
// 	}
// 	return sum;
// }
// Console.WriteLine(SumNumbers(m,n));
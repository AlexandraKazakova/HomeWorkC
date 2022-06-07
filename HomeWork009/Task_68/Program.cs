// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
Console.Write("Введите число m -> ");
int numM = int.Parse(Console.ReadLine());
Console.Write("Введите число n -> ");
int numN = int.Parse(Console.ReadLine());

int AkkermanFunction(int m, int n)
{
	if (m == 0)
	{
		return n + 1;
	}
	else if ((m > 0) && (n == 0))
	{
		return AkkermanFunction(m - 1, 1);
	}
	else if ((m > 0) && (n > 0))
	{
	return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
	}
	return -1;
}
int result = AkkermanFunction(numM, numN);
Console.Write($"{result}");

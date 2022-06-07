// Задача 61: Вывести первые N строк треугольника
// Паскаля. Сделать вывод в виде равнобедренного
// треугольника.

Console.Write($"Введите количество строк треугольника Паскаля: ");
int num = int.Parse(Console.ReadLine());

float Factorial(int n)
{
	float i, x = 1;
	for (i = 1; i <= n; i++)
	{
		x *= i;
	}
	return x;
}

void PrintPaskal(int line)
{
	int c = 0;
	for (int i = 0; i < line; i++)
	{
		for (c = 0; c <= (line - i); c++)
		{
			Console.Write(" ");
		}
		for (c = 0; c <= i; c++)
		{
			Console.Write(" ");
			Console.Write(Factorial(i) / (Factorial(c) * Factorial(i - c)));
		}
		Console.WriteLine();
		Console.WriteLine();
	}
}

PrintPaskal(num);

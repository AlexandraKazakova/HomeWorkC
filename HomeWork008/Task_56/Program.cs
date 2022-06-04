// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.
int[,] GetArray(int a, int b)
{
	int[,] arr = new int[a, b];
	Random rnd = new Random();
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			arr[i, j] = rnd.Next(10);
		}
	}
	return arr;
}

void PrintArray(int[,] arr)
{
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			Console.Write($"{arr[i, j]} ");
		}
		Console.WriteLine();
	}
}

void FindMinSum(int[,] arr)
{
	int result = 0;
	int row = 1;
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		int sum = 0;
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			sum += arr[i, j];
			if (i == 0)
			{
				result = sum;
			}
		}
		if (result > sum)
		{
			result = sum;
			row = i + 1;
		}

	}
	Console.WriteLine($"Наименьшая сумма элементов в строке {row} = {result}");
}

int[,] array = GetArray(3, 4);
PrintArray(array);
FindMinSum(array);
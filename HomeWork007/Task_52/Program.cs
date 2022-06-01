// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.

int[,] GetArray(int a, int b)
{
	int[,] array = new int[a, b];
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i, j] = new Random().Next(1, 10);
		}
	}
	return array;
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

void AvarageColumn(int[,] nextArray)
{
	double sum = 0;
	double count = 0;
	Console.Write($"Среднее арифметическое каждого столбца: ");
	for (int i = 0; i < nextArray.GetLength(1); i++)
	{
		for (int j = 0; j < nextArray.GetLength(0); j++)
		{
			sum += nextArray[j, i];
			count++;
		}
		Console.Write($"{Math.Round((sum / count), 1)}; ");
		sum = 0;
		count = 0;
	}
}

int[,] newArr = GetArray(3, 4);
PrintArray(newArr);
Console.WriteLine();
AvarageColumn(newArr);
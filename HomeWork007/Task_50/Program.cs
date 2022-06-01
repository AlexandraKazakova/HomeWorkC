// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите позицию элемента двумерного массива -> ");
int rowNumber = int.Parse(Console.ReadLine());
int columnNumber = int.Parse(Console.ReadLine());

int[,] array = new int[5, 5];

void FillArray(int[,] arr)
{
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			array[i, j] = new Random().Next(-10, 10);
		}
	}
}

void FindNumber(int[,] fillArr, int a, int b)
{
	if (a <= fillArr.GetLength(0)
	&& b <= fillArr.GetLength(1))
	{
		Console.WriteLine($"{fillArr[a, b]}");
	}
	else
	{
		Console.WriteLine($"{rowNumber},{columnNumber} -> такого такого элемента в массиве нет");
	}
}

FillArray(array);
FindNumber(array, rowNumber, columnNumber);
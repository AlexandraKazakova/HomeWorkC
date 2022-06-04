// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] FillArray(int a, int b)
{
	int[,] array = new int[a, b];
	Random rndNum = new Random();
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i, j] = rndNum.Next(10);
		}
	}
	return array;
}

void SortArrayInDescend(int[,] arr)
{
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
			for (int k = 0; k < arr.GetLength(1); k++)
			{
				if (arr[i, k] >= arr[i,j]) continue;
				int temp = arr[i, j];
				arr[i, j] = arr[i, k];
				arr[i, k] = temp;
			}
	}
}
void PrintArray(int[,] newarr)
{
	for (int i = 0; i < newarr.GetLength(0); i++)
	{
		for (int j = 0; j < newarr.GetLength(1); j++)
		{
			Console.Write($"{newarr[i,j]} ");
		}
		Console.WriteLine();
	}
}

int[,] myarray = FillArray(5,5);
PrintArray(myarray);
Console.WriteLine();
SortArrayInDescend(myarray);
PrintArray(myarray);
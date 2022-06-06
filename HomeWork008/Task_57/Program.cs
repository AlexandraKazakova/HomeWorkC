// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

int[,] GetArray(int a, int b)
{
	int[,] arr = new int[a, b];
	Random rndNum = new Random();
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			arr[i, j] = rndNum.Next(10);
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

void Periodicity(int[,] arr)
{
	int count = 0;
	int temp = arr[0, 0];
	int doubleNumber = -1;
	for (int index1 = 0; index1 < arr.GetLength(0); index1++)
	{
		for (int index2 = 0; index2 < arr.GetLength(1); index2++)
		{
			temp = arr[index1, index2];
			for (int i = 0; i < arr.GetLength(0); i++)
			{

				for (int j = 0; j < arr.GetLength(1); j++)
				{
					if (arr[i, j] == doubleNumber)
					{
						continue;
					}
					else if (arr[i, j] == temp)
					{
						count++;
						arr[i, j] = doubleNumber;
					}
				}
			}
			if (temp != doubleNumber)
			{
				if (count == 2
					|| count == 3
					|| count == 4)
				{
					Console.WriteLine($"Элемент {temp} встречается в массиве - {count} раза");
				}
				else
				{
					Console.WriteLine($"Элемент {temp} встречается в массиве - {count} раз");
				}
				count = 0;
			}
		}
	}
}

int[,] TwinArray(int[,] arr)
{
	int[,] twin = new int [arr.GetLength(0),arr.GetLength(1)];
	for (int i = 0; i < twin.GetLength(0); i++)
	{
		for (int j = 0; j < twin.GetLength(1); j++)
		{
			twin[i,j] = arr[i,j];
		}
	}
	return twin;
}


	int[,] array = GetArray(3, 3);
	int[,] twinArray = TwinArray(array);
	PrintArray(array);
	Periodicity(twinArray);

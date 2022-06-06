// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.


int[,,] GetArray(int a, int b, int c)
{
	int[,,] arr = new int[a, b, c];
	HashSet<int> numbers = new HashSet<int>();
	Random rnd = new Random();
	int minV = 10;
	int maxV = 100;
	bool overWork = maxV - minV > a * b * c;
	while (overWork == true)
	{
		for (int i = 0; i < arr.GetLength(0); i++)
		{
			for (int j = 0; j < arr.GetLength(1); j++)
			{
				for (int k = 0; k < arr.GetLength(2); k++)
				{
				start:
					int num = rnd.Next(minV, maxV);
					if (!numbers.Contains(num))
					{
						numbers.Add(num);
						arr[i, j, k] = num;
					}
					else
					{
						goto start;
					}
				}
			}
		}
		return arr;
	}
	int[,,] overArray = new int[0, 0, 0];
	return overArray;
}
void PrintArray(int[,,] arr)
{
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			for (int k = 0; k < arr.GetLength(2); k++)
			{
				Console.WriteLine($"{arr[i, j, k]} - {i},{j},{k} ");
			}
		}
	}
	if (arr.GetLength(0) == 0
	|| arr.GetLength(1) == 0
	|| arr.GetLength(2) == 0)
	{
		Console.WriteLine($"Невозможно создать массив из " +
		"неповторяющихся чисел. Проверьте, что конечное количество " +
		"элементов массива меньше, чем диапазон рандомных чисел.");
	}
}

int[,,] array = GetArray(2, 2, 2);
PrintArray(array);


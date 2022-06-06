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
	Dictionary<int, int> vacabulary = new Dictionary<int, int>();
	foreach (int num in arr)
	{
		if (vacabulary.ContainsKey(num))
		{
			vacabulary[num]++;
		}
		else
		{
			vacabulary.Add(num, 1);
		}
	}
	foreach (KeyValuePair<int, int> pair in vacabulary)
	{
		Console.WriteLine("Частота {0} = {1} ", pair.Key, pair.Value);
	}
}



int[,] array = GetArray(3, 3);
PrintArray(array);
Console.WriteLine();
Periodicity(array);

// Задача 62: Заполните спирально массив 4 на 4.
// Доп. задача 1.
Console.WriteLine($"Введите размерность массива: ");
int row = int.Parse(Console.ReadLine());
int column = int.Parse(Console.ReadLine());

int[,] FillArray(int m, int n)
{
	int[,] arr = new int[m, n];
	int r = 1;
	int c = 1;
	int num = 1;

	for (int y = 0; y < n; y++)
	{
		arr[0, y] = num;
		num++;
	}
	for (int x = 1; x < m; x++)
	{
		arr[x, n - 1] = num;
		num++;
	}
	for (int y = n - 2; y >= 0; y--)
	{
		arr[m - 1, y] = num;
		num++;
	}
	for (int x = m - 2; x > 0; x--)
	{
		arr[x, 0] = num;
		num++;
	}
	while (num < m * n)
	{
		while (arr[r, c + 1] == 0)
		{
			arr[r, c] = num;
			num++;
			c++;
		}
		while (arr[r + 1, c] == 0)
		{
			arr[r, c] = num;
			num++;
			r++;
		}
		while (arr[r, c - 1] == 0)
		{
			arr[r, c] = num;
			num++;
			c--;
		}
		while (arr[r - 1, c] == 0)
		{
			arr[r, c] = num;
			num++;
			r--;
		}
	}
	arr[r,c] = num;
	return arr;
}



void PrintArray(int[,] arr)
{
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			Console.Write($"{arr[i, j]}\t");
		}
		Console.WriteLine();
	}
}


int[,] array = FillArray(row, column);
PrintArray(array);
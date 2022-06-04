// Задача 58*: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.
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

int[,] Multiplication(int[,] arrFirst, int[,] arrSecond)
{
	int[,] arrThird = new int[arrFirst.GetLength(0),arrFirst.GetLength(1)];
	for (int i = 0; i < arrThird.GetLength(0); i++)
	{
		for (int j = 0; j < arrThird.GetLength(1); j++)
		{
			arrThird[i, j] = arrFirst[i, j] * arrSecond[i, j];
		}
	}
	return arrThird;
}

int[,] matrixFirst = GetArray(3, 3);
int[,] matrixSecond = GetArray(3, 3);
int[,] matrixThird = Multiplication(matrixFirst,matrixSecond);
PrintArray(matrixFirst);
Console.WriteLine();
PrintArray(matrixSecond);
Console.WriteLine();
PrintArray(matrixThird);
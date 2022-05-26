// Задача 38: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.
Console.WriteLine("Задайте размер массива-> ");
int size = int.Parse(Console.ReadLine());
double[] array = new double[size];

void FillArray(double[] arr)
{
	int length = arr.Length;
	int index = 0;
	while(index < arr.Length)
	{
		arr[index] = new Random().NextDouble() * (new Random().Next(-100,100));
		index++;
	}
}
void PrintArray(double[] col)
{
	int mass = col.Length;
	int position = 0;
	while (position < mass)
	{
		Console.Write($"{Math.Round(col[position], 3)}, ");
		position++;
	}
}

void FindDiff(double[] collection)
{
	int sizeArr = collection.Length;
	int numIndex = 0;
	double max = 0;
	double min = 0;
	while(numIndex < sizeArr)
	{
		if(max < collection[numIndex]) max = collection[numIndex];
		else if(min > collection[numIndex]) min = collection[numIndex];
		numIndex++;
	}
	double result = max - min;
	Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {Math.Round(result,3)}");
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
FindDiff(array);

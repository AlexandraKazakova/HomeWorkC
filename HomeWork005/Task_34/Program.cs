// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.
Console.WriteLine("Задайте размер массива-> ");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];

void FillArray(int[] arr)
{
	int length = arr.Length;
	int index = 0;
	while(index < arr.Length)
	{
		arr[index] = new Random().Next(100,1000);
		index++;
	}
}

void PrintArray(int[] col)
{
	int mass = col.Length;
	int position = 0;
	while (position < mass)
	{
		Console.Write($"{col[position]}, ");
		position++;
	}
}

void FindEvenNumber(int[] numbers)
{
	int rate = numbers.Length;
	int count = 0;
	for (int pos = 0; pos < rate; pos++)
	{
		if(numbers[pos] % 2 == 0) count += 1;
	}
	Console.WriteLine(count);
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
FindEvenNumber(array);
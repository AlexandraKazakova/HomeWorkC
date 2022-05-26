// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.

Console.WriteLine("Задайте размер массива-> ");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];

void FillArray(int[] arr)
{
	int length = arr.Length;
	int index = 0;
	while(index < arr.Length)
	{
		arr[index] = new Random().Next(1,100);
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

int FindSumNum(int[] newArr)
{
	int arrSize = newArr.Length;
	int summ = 0;
	for (int i = 1; i < arrSize; i += 2)
	{
		summ += newArr[i];
	}
	return summ;
}

//int result = FindSumNum(array);
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {FindSumNum(array)}");
//Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {result}");
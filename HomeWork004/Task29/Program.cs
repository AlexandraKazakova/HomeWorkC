// Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран
Console.WriteLine("Введите размер массива -> ");
int num = int.Parse(Console.ReadLine());
int[] newArray = new int[num];
// int arrLength = newArray.Length;
// int pos = 0;

void FillArray(int[] collection)
{
	int length = collection.Length;
	int index = 0;
	while (index < length)
	{
		collection[index] = new Random().Next(1,100);
		index++;
	}
}

void PrintArray(int[] col)
{
	int count = col.Length;
	int position = 0;
	while (position < count)
	{
		Console.Write($"{col[position]}, ");
		position++;
	}
}
FillArray(newArray);
PrintArray(newArray);
// Console.Write("[");
// while(pos < newArray.Length - 1)
// {
// 	Console.Write($"{newArray[pos]}, ");
// 	pos++;
// }
// Console.Write($"{newArray[pos]}]");
// pos++;

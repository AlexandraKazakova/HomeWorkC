// Напишите программу, которая принимает на вход
// число и выдает сумму цифр в числе.
Console.WriteLine("Введите число -> ");
int number = int.Parse(Console.ReadLine());

int FindSum(int num)
{
	int sum = 0;
	while(num != 0)
	{
		sum += num % 10;
		num = num / 10;
	}
	return sum;
}
int result = FindSum(number);
Console.WriteLine(result);

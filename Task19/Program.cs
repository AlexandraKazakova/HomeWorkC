// Задача 19: Напишите программу, которая принимает на
//вход пятизначное число и проверяет, является ли оно
//палиндромом.

Console.WriteLine("Введите пятизначное число -> ");
string a = Console.ReadLine();
int length = a.Length;
if(length == 5)
{
	if(a[0] == a[4] && a[1] == a[3])
	{
		Console.WriteLine($"Число {a} является палиндромом");
	}
	else Console.WriteLine($"Число {a} не является палиндромом");
}
else Console.WriteLine("Некорректное число");
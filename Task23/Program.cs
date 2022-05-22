//Напишите программу, которая принимает на
//вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число ");
var n = int.Parse(Console.ReadLine());
Console.WriteLine("|Число|\tКуб|");
for(int x = 1; x <= n; x++)
{
	Console.WriteLine("|{0,5}|\t{1,3}|", x, Math.Pow(x, 3));
}
if(n < 1)
{
	Console.WriteLine($"{n} - некорректное число");
}
// Напишите цикл, который принимает на вход
// два числа (А и В) и возводит число А в
// натуральную степень В
Console.WriteLine("Введите два числа -> ");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int result = 1;
if (num2 < 0) num2 = num2 * -1;
if (num2 == 0) result = 0;
for(int count = 0; count < num2; count++)
{
	result = result * num1;
}
Console.WriteLine(result);
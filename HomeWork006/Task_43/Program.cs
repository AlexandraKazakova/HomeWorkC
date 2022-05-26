// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
Console.WriteLine("Введите координату k1 -> ");
float k1 = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Введите координату b1 -> ");
float b1 = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Введите координату k2 -> ");
float k2 = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Введите координату b2 -> ");
float b2 = Convert.ToSingle(Console.ReadLine());
float x = ((b1 - b2) * -1) / (k1 - k2);
float y = k2 * x + b2;
if(b1 - b2 == 0) Console.WriteLine("Прямые либо совпадают, либо параллельны");
else if (b1 -b2 != 0) Console.WriteLine($"Координаты пересечения прямых - [{Math.Round(x,3)},{Math.Round(y,3)}]");

// Составим систему из уравнений этих прямых
// y = 5x + 2
// y = 9x + 4
// Из первого уравнения вычтем второе уравнение
// y - y = 5x + 2 - 9x - 4
// y = 9x + 4
 
// 0 = - 4x - 2
// y = 9x + 4
 
// - 4x = 2
// y = 9x + 4
 
// x = 2 : (-4) = -0.5
// y = 9x + 4
// Подставим значение x из первого уравнения во второе и найдем значение y
// x = -0.5
// y = 9·(-0.5) + 4 = -0.5
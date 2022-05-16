// Напишите программу, которая принимает на
//вход координаты двух точек и находит расстояние между
//ними в 3D пространстве.
Console.WriteLine("Введите координаты точки А: ");
double ax = Convert.ToDouble(Console.ReadLine());
double ay = Convert.ToDouble(Console.ReadLine());
double az = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
double bx = Convert.ToDouble(Console.ReadLine());
double by = Convert.ToDouble(Console.ReadLine());
double bz = Convert.ToDouble(Console.ReadLine());

double ab = Math.Sqrt(Math.Pow((bx - ax),2) + Math.Pow((by - ay),2) + Math.Pow((bz - az),2));

Console.WriteLine(Math.Round(ab,2));
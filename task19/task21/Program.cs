// Напишите программу,которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//А(3,6,8); В(2,1,-7), -> 15.84
//A(7,-5,0); В(1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки:");
int X1 = Convert.ToInt32(Console.ReadLine());
int Y1 = Convert.ToInt32(Console.ReadLine());
int Z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координатывторой точки:");
int X2 = Convert.ToInt32(Console.ReadLine());
int Y2 = Convert.ToInt32(Console.ReadLine());
int Z2 = Convert.ToInt32(Console.ReadLine());
double distance = Math.Sqrt((X2-X1)*(X2-X1)+(Y2-Y1)*(Y2-Y1)+(Z2-Z1)*(Z2-Z1));
Console.WriteLine($"Расстояние между точками { distance:f2}");

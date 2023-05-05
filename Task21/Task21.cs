// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

int ReadInt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] CoordinateA = new int[3];
CoordinateA[0] = ReadInt("Введите координату X точки A: ");
CoordinateA[1] = ReadInt("Введите координату Y точки A: ");
CoordinateA[2] = ReadInt("Введите координату Z точки A: ");

int[] CoordinateB = new int[3];
CoordinateB[0] = ReadInt("Введите координату X точки B: ");
CoordinateB[1] = ReadInt("Введите координату Y точки B: ");
CoordinateB[2] = ReadInt("Введите координату Z точки B: ");

double dist = Math.Sqrt(Math.Pow(CoordinateA[0] - CoordinateB[0], 2) + Math.Pow(CoordinateA[1] - CoordinateB[1], 2) + Math.Pow(CoordinateA[2] - CoordinateB[2], 2));

Console.WriteLine($"Расстояние между точками A и B:  {Math.Round(dist, 3)}");


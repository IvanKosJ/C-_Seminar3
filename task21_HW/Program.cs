// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Lenght (int xA, int yA, int zA, int xB, int yB, int zB)
{
    double distance = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));
    return distance;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = GetInfo("Введите координату X первой точки: ");
int y1 = GetInfo("Введите координату Y первой точки: ");
int z1 = GetInfo("Введите координату Z первой точки: ");
int x2 = GetInfo("Введите координату X второй точки: ");
int y2 = GetInfo("Введите координату Y второй точки: ");
int z2 = GetInfo("Введите координату Z второй точки: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

Console.WriteLine($"Расстоние между двумя точками на плоскости равно: {Lenght (x1, y1, z1, x2, y2, z2)}");
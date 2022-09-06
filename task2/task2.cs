// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

string[] pName = new string[] { "k1", "b1", "k2", "b2" };
double[] points = new double[4];
double resX,
       resY;

for (int i = 0; i < 4; i++)
{
    System.Console.Write($"Введите координату {pName[i]}:  ");
    points[i] = Convert.ToDouble(Console.ReadLine());
}

if (points[0] == points[2])
{
    System.Console.WriteLine("Прямые параллельны");
}
else
{
    resX = (points[3] - points[1]) / (points[0] - points[2]);
    resY = points[0] * resX + points[1];
    System.Console.WriteLine($"Координаты пересечения: {resX}, {resY}");
}



// Задача 1: Программа запрашивает натуральное число M, пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

Console.Write("Ведите натуральное число М:  ");
int m = Int32.Parse(Console.ReadLine());
int count = 0;

for (int i = 0; i < m; i++)
{
    Console.Write("Ведите число " + (i + 1) + ":  ");
    int num = Int32.Parse(Console.ReadLine());
    if (num > 0) count++;
}

Console.WriteLine(count);









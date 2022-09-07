using System;
// * Найдите сумму произведений пар чисел в одномерном целочисленном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Если кол-во элементов нечетное, то элемент посередине не учитывать.
// Результат сложения вывести на экран.
// 1, 3, 8, 3, 2 -> 11
// 8, 3, 4, 2 -> 22

Console.Clear();

Random rnd = new Random();
int sum = 0;

int size = rnd.Next(5, 10);
int[] arr = new int[size];
for (int i = 0; i < size; i++)
{
    arr[i] = rnd.Next(9);
}

for (int i = 0; i < size / 2; i++)
{
    sum += arr[i] * arr[size - 1 - i];
}

Console.WriteLine(String.Join(" ", arr));
Console.WriteLine("Сумма произв. пар элементов= " + sum);


﻿// Найти произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элелмент, второй и
// предпоследний и т.д. Результат запишите в новый массив.

// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

int[] array = {1, 3, 2, 9, 4, 2, 3};

int n = array.Length - 1;

int[] result = new int[array.Length / 2];

for (int i = 0; i < n-i; i++)
{
    result[i] = array[i] * array[n-i];
}

for (int i =0; i < result.Length; i++)
{
    System.Console.Write(result[i] + " ");
}

if (array.Length % 2 == 1)
{
    System.Console.WriteLine($"(элемент {array[array.Length / 2]} не имеет пары)");
}
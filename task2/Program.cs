// Задайте массив из 10 элелментов, заполненный числами из 
// промежутка [-10, 10]. Замените отрицательные элелменты на 
// положитлеьные, а положительные на отрицательные.

// Пример
// [1 -5 6] => [-1 5 -6]

const int size = 10;
int[] array = new int[size] { 1, -5, 6, 3, 6, 10, -10, -2, 5, -6 };

for (int i = 0; i < array.Length; i++)
{
    System.Console.Write(array[i] + " ");
}
System.Console.WriteLine();

for (int i = 0; i < size; i++)
{
    array[i] = -array[i];
}
for (int i = 0; i < size; i++)
{
    System.Console.Write(array[i] + " ");
}

// Массивы. 
// Задайте массив. Напишите прогу, которая определяет, присутствует ли заданное число в массиве.
// Программа должна выдать ответ: Да или Нет. 

int[] array = { 1, 3, 5, 8, 12, 0, 23 };
int number = 24;
bool result = false;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == number)
   
      { result = true;
            break;
      }
}       

if (result == true)
    {
        System.Console.WriteLine("Yes");
    }
    
else
    {
        System.Console.WriteLine("No");
    }




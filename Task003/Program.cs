/*
Задайте массив вещественных чисел. Найдите разницу 
между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

int[] InitArray()
{
int[] result = new int[4];
Random rnd = new Random();

for (int i = 0; i < result.Length; i++)
{
result[i] = rnd.Next(0, 101);
}

return result;
}

void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write($"{array[i]} ");
}
}

int GetMax (int[] array)
{
int max = 0;
for (int i = 0; i < array.Length; i++)
{
if(array[i] > max)
max = array[i];
}

return max;
}

int GetMin (int[] array)
{
int min = array[0];
for (int i = 0; i < array.Length; i++)
{
if(array[i] < min)
min = array[i];
}

return min;
}

int[] arr = InitArray();
PrintArray(arr);
int max = GetMax(arr);
int min = GetMin(arr);

Console.WriteLine($" max -> {max}, min -> {min}, разница между -> {max - min}");






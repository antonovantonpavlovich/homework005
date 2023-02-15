/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

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

int GetPositiveSum(int[] array)
{
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
if (i%2!=0)
{
    sum = sum + array[i];
}

}

return sum;
}

int[] arr = InitArray();
PrintArray(arr);
int sum = GetPositiveSum(arr);

Console.WriteLine($"-> {sum}");



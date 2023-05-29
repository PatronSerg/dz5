// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] array = new int[10];
int count = 0;
Random random = new Random();
Console.WriteLine("Массив случайных трёхзначных чисел:");
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(100, 1000);
    Console.Write("{0} ", array[i]);
    if (array[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine("Количество чётных чисел в массиве: {0}", count);


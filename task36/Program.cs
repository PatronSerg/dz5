// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] myArray = new int[10];
Random random = new Random();
for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = random.Next(1, 100);
}
int sum = 0;
for (int i = 1; i < myArray.Length; i += 2)
{
    sum += myArray[i];
}
Console.WriteLine("Сумма элементов на нечетных позициях: " + sum);
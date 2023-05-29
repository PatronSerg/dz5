// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.



double[] numbers = { 1.2, 3.4, 5.6, 7.8, 9.0 };
double max = numbers[0];
double min = numbers[0];
foreach (double number in numbers)
{
    if (number > max)
    {
        max = number;
    }
    if (number < min)
    {
        min = number;
    }
}
double difference = max - min;
Console.WriteLine("Разница между максимальным и минимальным элементами: " + difference);





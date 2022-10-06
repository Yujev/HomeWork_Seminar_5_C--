/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
Console.WriteLine();
Console.WriteLine("Задача: Найди разницу между максимальным и минимальным элементом массива. ");
Console.WriteLine();
Console.WriteLine("Твой массив: ");
Console.WriteLine();

double[] array = new double[5];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 999 + 1);

    Console.Write(array[i] + " ");
}
Console.WriteLine();

double minNumbersCount = array[0]; // Минимальный элемент массива
double maxNumbersCount = array[0]; // Максимальный элемент массива

for (int i = 1; i < array.Length; i++)
{
    if (maxNumbersCount < array[i])
    {
        maxNumbersCount = array[i];
    }
    if (minNumbersCount > array[i])
    {
        minNumbersCount = array[i];
    }

}
double subtraction = maxNumbersCount - minNumbersCount;
Console.WriteLine();
Console.WriteLine($"Разница между {maxNumbersCount} и {minNumbersCount} = {subtraction}");
Console.WriteLine();
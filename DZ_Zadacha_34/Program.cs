/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

int[] array = GetArray(4, 100, 999);
Console.WriteLine("Ваш массив: ");
Console.WriteLine(String.Join(" ", array));


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] massive = new int[size];

    for (int i = 0; i < size; i++)
    {
        massive[i] = new Random().Next(minValue, maxValue + 1);
    }
    return massive;

}

int evenNumbersCount = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        evenNumbersCount ++;  //Подсчёт суммы чётных - evenNumbersCount += array[i];
    }
}

Console.WriteLine($"Количество чётных чисел в массиве: {evenNumbersCount}");



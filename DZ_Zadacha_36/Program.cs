/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

int[] array = GetArray(7, -15, 100);
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

//int evenNumbersCount = 0; // Чётные элементы
int oddNumbersCount = 0; // Нечётные элементы

for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
    {
        oddNumbersCount += array[i];
    }
    
}

Console.WriteLine($"Сумма элементов на  нечётных позициях: {oddNumbersCount}");




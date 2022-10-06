/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/
Console.WriteLine();
Console.WriteLine("Задача 36: Найди сумму элементов, стоящих на нечётных позициях");
Console.WriteLine();
int[] array = GetArray(7, -15, 100);
Console.WriteLine("Твой массив: ");
Console.WriteLine();
Console.WriteLine(String.Join(" ", array));
Console.WriteLine();

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
Console.WriteLine();



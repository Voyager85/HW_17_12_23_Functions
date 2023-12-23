// Задача 2: 
// Задайте массив заполненный случайными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

void FillArray(int[] array, int min, int max)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(min, max);
        index++;
    }
}
void PrintArray(int[] array)
{
    System.Console.Write("МАССИВ: ");
    for (int index = 0; index < array.Length; index++)
    {
        System.Console.Write(array[index] + " ");
    }
    System.Console.WriteLine("");
}

int[] array = new int[10];
int length = array.Length;
FillArray(array, 100,999);
PrintArray(array);

int count = 0;
for (int i = 0; i < length; i++)
{
    if (array[i] % 2 == 0) count++;
}

System.Console.WriteLine("Количество четных элементов массива = " + count);
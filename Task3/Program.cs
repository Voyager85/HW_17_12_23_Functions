// Задача 3:
// Напишите программу, которая перевернёт одномерный массив
// (первый элемент станет последним, второй – предпоследним и т.д.)

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
    for (int index = 0; index < array.Length; index++)
    {
        System.Console.Write(array[index] + " ");
    }
    System.Console.WriteLine("");
}

int[] array = new int[11];
int length = array.Length;
FillArray(array, 1,100);
System.Console.Write("Изначальный  массив: ");
PrintArray(array);

int tmp = -1;
for (int i = 0; i < length/2; i++)
{
    tmp = array[i];
    array[i]  = array [length - i - 1];
    array[length - i - 1] = tmp;
}

System.Console.Write("Перевернутый массив: ");
PrintArray(array);
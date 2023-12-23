// Задача 1:
// Напишите программу, которая бесконечно запрашивает
// целые числа с консоли. Программа завершается при вводе
// символа ‘q’ или при вводе числа, сумма цифр которого чётная.

int num = 0;
int evenSum = 0;
string s = " ";
System.Console.WriteLine("Введите число: ");
while ((s = Console.ReadLine()) != "q")
{
    try
    {
        num = Convert.ToInt32(s);
        if (num <= 0)
        {
            System.Console.WriteLine("Введите положительное число: ");
        }
        else
        {
            int var = num;
            evenSum = 0;

            while (var > 0)
            {
                evenSum += var % 10;
                var /= 10;
            }
            if (evenSum % 2 == 0) return;
            System.Console.WriteLine("Введите число: ");
        }
    }
    catch (Exception ex)
    {
        System.Console.WriteLine("Вы не ввели число!");
        System.Console.WriteLine("Введите число: ");
    }
}

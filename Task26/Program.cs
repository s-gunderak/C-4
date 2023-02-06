// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Количество цифр в числе {num} равняется {NumCount(num)}");
int NumCount(int number)
{
    int count = 0;
    while (num > 0)
    {
        num /= 10;
        count++;
    }
    return count;
}

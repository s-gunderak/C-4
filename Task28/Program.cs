// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Произведение чисел от 1 до {num} равняется {GetProductNums(num)}");
int GetProductNums(int number)
{
    int product = 1;
    for (int i = 1; i <= number; i++)
    {
        product *= i;
    }
    return product;
}
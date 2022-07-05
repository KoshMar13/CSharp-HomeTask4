// 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int NumDigitSum(int number)
{
    int sum = 0;
    for (int i = number; i > 0; i /= 10)
    {
        sum += i % 10;
    }
    return sum;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(NumDigitSum(num));

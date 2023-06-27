Console.Clear();
int DigitSum(int number)
{
    int result = 0;
    while (number > 0)
    {
        result = result + number%10;
        number = number/10;
    }
    return result;
}
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int res = DigitSum(num);
Console.Write($"Сумма цифр числа {num} - {res}");
Console.Clear();
int Power(int number, int exp)
{
    int result = 1;
    for (int i = 0; i < exp; i++)
    {
        result = result * number;
    }
    return result;
}
bool ExpVal(int exp)
{
    if (exp <= 0)
    {
        Console.Write("показатель степени должен быть больше 0");
        return false;
    }
    return true;
}
Console.WriteLine("Введите основание степени");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Введите показатель степени, натуральное число");
int expon = int.Parse(Console.ReadLine());
if (ExpVal(expon))
{
    int res = Power(num, expon);
    Console.Write($"Число {num}, возведённое в {expon} степень = {res}");
}
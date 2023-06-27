Console.Clear();
void FillArray(int[] array, int beg, int fin)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(beg, (fin + 1));
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
Console.WriteLine("Введите размер массива");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите начальный параметр диапазона массива");
int beg1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите конечный параметр диапазона массива");
int fin1 = int.Parse(Console.ReadLine());
int[] array1 = new int[num1];
FillArray(array1, beg1, fin1);
PrintArray(array1);
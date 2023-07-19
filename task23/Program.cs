// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
int GetData(string text)
{
    Console.Write(text);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}
void GetKub(int limit)
{
    for (int i = 1; i < limit; i++)
    {
        Console.Write($"{i*i*i}, ");
    }
    Console.Write(limit*limit*limit);
}
int num = GetData("Введите число N ");
GetKub(num);
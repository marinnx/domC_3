// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
int GetData(string text)
{
    Console.Write(text);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}
string TestNumber(int number)
{string otvet = "";
    if (number / 10000 == number %10 && number / 1000 % 10 == number / 10 % 10)
    {
        otvet = "да";
    }
    else
    {
        otvet = "нет";
    }
    return otvet;
}
int num = GetData("Введите пятизначное число: ");
Console.WriteLine($"{num} -> {TestNumber(num)}");

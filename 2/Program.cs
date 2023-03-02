// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadLine(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Count(int number)

{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}

int number = ReadLine("Введите число: ");

int sum = Count (number);

System.Console.Write(sum);
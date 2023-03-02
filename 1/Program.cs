// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadLine(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = ReadLine("Введите число А: ");

int number1 = ReadLine("Введите число А: ");

System.Console.Write(Math.Pow(number, number1));
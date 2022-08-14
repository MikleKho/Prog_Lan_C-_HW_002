// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int Prompt(string message)
{
    System.Console.Write(message);
    string ReadValue = Console.ReadLine();
    int result = int.Parse(ReadValue);
    return result;
}
int value_01 = Prompt("Введите положительное трехзначное число (от 100 до 999) -> ");
if ((value_01 > 999) | (value_01 < 100))
{
    System.Console.Write("Input error");
}
else
{
    int result_num = ((value_01 - (value_01 % 10)) / 10) % 10;
    System.Console.Write($"Вторая цифра -> {result_num}");
}

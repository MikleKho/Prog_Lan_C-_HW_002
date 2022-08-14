// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int Prompt(string message)
{
    System.Console.Write(message);
    string ReadValue = Console.ReadLine();
    int result = int.Parse(ReadValue);
    return result;
}

int Second_num(int value_in)
{
    int result_num = ((value_in - (value_in % 10)) / 10) % 10;
    return result_num;
}

int value_01 = Prompt("Введите положительное трехзначное число (от 100 до 999) -> ");
if ((value_01 > 999) | (value_01 < 100))
{
    System.Console.Write("Input error");
}
else
{
    System.Console.Write($"Вторая цифра -> {Second_num(value_01)}");
}

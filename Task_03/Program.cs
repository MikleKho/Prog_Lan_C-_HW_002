// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int Prompt(string message)
{
    System.Console.Write(message);
    string ReadValue = Console.ReadLine();
    int result = int.Parse(ReadValue);
    return result;
}

int value_01 = Prompt("Введите число -> ");
if ((value_01 - (value_01 % 100)) != 0)
{
    System.Console.Write($"Третья цифра -> {((value_01 - value_01 % 100) / 100) % 10}");
}
else
{
    System.Console.Write("Третьей цифры нет");
}


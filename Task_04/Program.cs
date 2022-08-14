// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
int Prompt(string message)
{
    System.Console.Write(message);
    string ReadValue = Console.ReadLine();
    int result = int.Parse(ReadValue);
    return result;
}

int value_01 = Prompt("Введите номер дня недели (от 1 до 7) -> ");
if ((value_01 > 7) | (value_01 < 1))
{
    System.Console.Write("Input error");
}
else
{
    if (value_01 == 6 | value_01 == 7)
    {
        System.Console.Write("Выходной день");
    }
    else
    {
        System.Console.Write("Рабочий день");
    }
}

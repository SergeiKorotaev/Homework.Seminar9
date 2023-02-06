Console.WriteLine("Введите число от 1:");
int number = int.Parse(Console.ReadLine());

void PrintNumbers (int number)
{
    if (number < 0) Console.Write("Неверныйй ввод");
    if (number == 0) return;
    Console.Write("{0,4}", number);
    PrintNumbers (number - 1);
}

PrintNumbers(number);

Console.WriteLine("Введите число M:");
int numberM = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N:");
int numberN = int.Parse(Console.ReadLine());

void Sum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма чисел от M до N = {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    Sum(numberM, numberN, sum);
}

Sum(numberM, numberN, 0);;

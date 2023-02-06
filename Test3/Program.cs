Console.WriteLine("Введите число M:");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N:");
int numberN = int.Parse(Console.ReadLine());

int AckkerFun(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AckkerFun(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AckkerFun(numberM - 1, AckkerFun(numberM, numberN - 1));
return AckkerFun(numberM, numberN);
}

Console.WriteLine($"Функция Аккермана для чисел A({numberM}, {numberN}) = {AckkerFun(numberM, numberN)}");

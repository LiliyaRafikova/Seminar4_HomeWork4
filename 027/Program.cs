Console.WriteLine("Программа, которая принимает на вход число и выдаёт сумму цифр в числе.");
 int GetSumma(int Number)
{
    int summa = 0;
    while (Number > 0)
    {
        int num = Number % 10;
        summa = summa + num;
        Number = Number / 10;
    }
    return summa;

}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int Summa = GetSumma(number);
Console.WriteLine($"Cумма всех цифр в числе равна: {Summa}");

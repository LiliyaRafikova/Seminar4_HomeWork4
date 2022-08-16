Console.WriteLine("Программа которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
int GetPow (int numA, int numB)
{
    int result = 1;
    for (int i = 0; i < numB; i++)
    {
        result *= numA;
    }
    return result;
}
Console.Write("Введите число А: ");
int numberA=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB=Convert.ToInt32(Console.ReadLine());
int pow = GetPow(numberA, numberB);
Console.Write($"{numberA} ^ {numberB} = {pow}");

// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Применять Math.Pow нельзя!

Console.WriteLine("введите первое число:   ");
string A1 = Console.ReadLine ();
Console.WriteLine("введите второе число:   ");
string B1 = Console.ReadLine ();
int result = 1;
try
{
    int A = int.Parse (A1);
    int B = int.Parse (B1);
for (int i = 0; i < B; i++)
{
    result = result * A;
}
Console.WriteLine("Произведение  " + A + "  на  " + B + " = " + result);
}
catch
    {
        Console.WriteLine("Вы ввели не число");
    }
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


Console.WriteLine("введите число:   ");
string number = Console.ReadLine ();
int L = number.Length;
int result = 0;
try 
{
for (int i = 0; i < L; i++)
{
    
    result = result + int.Parse($"{number[i]}");
}
    System.Console.WriteLine(result);
    }
    catch
    {
        System.Console.WriteLine("Вы ввели не число  ");
    }

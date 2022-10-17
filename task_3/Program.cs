//Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
//(на входе N- длина массива, min и max- ограничения для значений элементов массива, которые лежат в [min, max])

int vvod (string messege)
{
    Console.WriteLine(messege);
    int result = int.Parse (Console.ReadLine ());
    return result;
}
try
{
int L = vvod("Введите длину массива:  ");
int min = vvod("Введите min значение массива:  ");
int max = vvod("Введите max значение массива:  ");
int [] massiv = new int [L];
Random rand = new Random();
for (int i = 0; i < L; i++)
{
   massiv [i] = rand.Next(min,max);
   System.Console.Write(massiv[i]+", ");
}
}
catch
{
    Console.WriteLine("Вы ввели не число");
}
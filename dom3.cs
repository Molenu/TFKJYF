//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 3 -> 1, 8, 275 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int D=Convert.ToInt32(Console.ReadLine());

for ( int g=1;g<=D ;g++)
{
    Console.WriteLine(Math.Pow(g,3));
}
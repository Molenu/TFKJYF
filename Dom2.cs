 //Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры не
//32679 -> 6
int dum=new Random().Next(1,1000000);
Console.WriteLine(dum);
string Dum1=Convert.ToString(dum);
if (Dum1.Length>2)
{
    Console.WriteLine(Dum1[2]);

}
else 
{
    Console.WriteLine("Третий цифры нету");
}
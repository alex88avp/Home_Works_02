//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Clear();
Console.Write("Введите Х: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите y: ");
int y = int.Parse(Console.ReadLine());

if(x > 0 && y > 0)
{
    Console.WriteLine("Четверть 1");
}
if(x < 0 && y > 0)
{
    Console.WriteLine("Четверть 2");
}
if(x < 0 && y < 0)
{
    Console.WriteLine("Четверть 3");
}
if(x > 0 && y < 0)
{
    Console.WriteLine("Четверть 4");
}
// Задать номер четверти, показать диапазоны для возможных координат
Console.Clear();
Console.Write("Введите номер четверти: ");
int q = int.Parse(Console.ReadLine());

if(q == 1)
{
    Console.WriteLine("x > 0 и у > 0");
}
if(q == 2)
{
    Console.WriteLine("x < 0 и у > 0");
}
if(q == 3)
{
    Console.WriteLine("x < 0 и у < 0");
}
if(q == 4)
{
    Console.WriteLine("x > 0 и у < 0");
}
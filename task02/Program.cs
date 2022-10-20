// По двум заданным числам проверять является ли одно квадратом другого
Console.Clear();
Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());

if(numberA == numberB * numberB)
{
    Console.WriteLine($"{numberA} является квадратом {numberB}");
}

else {
    Console.WriteLine($"{numberA} не является квадратом {numberB}");
}
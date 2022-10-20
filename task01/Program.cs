// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.Clear();

Console.Write("Введите число от 1 до 7: ");
int number = int.Parse(Console.ReadLine() ?? "0");
if(number <= 5)
{
    Console.WriteLine($"{number} является рабочим днём");
}
else {
    Console.WriteLine($"{number} является выходным днём");
}
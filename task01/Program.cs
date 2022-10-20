// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.Clear();

//Console.Write("Введите число от 1 до 7: ");
//int number = int.Parse(Console.ReadLine() ?? "0");
int number = new Random().Next(1, 7);
if(number <= 5)
{
    Console.WriteLine($"{number} является рабочим днём");
}
else {
    Console.WriteLine($"{number} является выходным днём");
}

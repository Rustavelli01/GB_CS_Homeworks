Console.Clear();
Console.Write("Введите первое целое число: ");
string userImput1 = Console.ReadLine() ?? "";
int a = int.Parse(userImput1);

Console.Write("Введите второе целое число: ");
string userImput2 = Console.ReadLine() ?? "";
int b = int.Parse(userImput2);

if (a == b * b)
{
    Console.WriteLine($" a = {a} , b={b} -> Да");
}
else
{
    Console.WriteLine($" a = {a} , b={b} -> Нет");
}


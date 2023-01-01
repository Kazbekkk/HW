Console.Clear();
// инициализируем переменные res и ok
double A, B, res = 0; bool ok = true;
Console.Write("Введите число А: ");
string sA = Console.ReadLine(); // ввод строки
if (!double.TryParse(sA, out A))
{
    Console.WriteLine("Не число!"); A = 1;
}
    A = double.Parse(sA); // преобразование в число
Console.Write("Введите число В: ");
string sB = Console.ReadLine();
if (!double.TryParse(sB, out B))
{
    Console.WriteLine("Не число!"); B = 1;
}
    B = double.Parse(sB);

Console.Write("Введите знак операции (+ - * /) ");
string op = Console.ReadLine();

switch (op)
{
    case "+": res = A + B; break;
    case "-": res = A - B; break;
    case "*": res = A * B; break;
    case "/": res = A / B; break;
    default: ok = false; break;
}
if (ok)
{
    Console.WriteLine("{0} {1} {2} = {3}", A, op, B, res); // вывод
}
else
{
    Console.WriteLine("Недопустимая операция");
}
Console.ReadKey();
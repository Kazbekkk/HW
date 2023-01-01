Console.Clear();
string mes;
Console.WriteLine("Введите день недели: Пн, Вт, Ср, Чт, Пт, Сб, Вс");
string day = Console.ReadLine();
switch (day)
{
    case "Сб": mes = "Иду в гости"; break;
    case "Вс": mes = "Отдыхаю"; break;
    default: mes = "Работаю"; break;
}
Console.WriteLine(mes);
Console.ReadKey();
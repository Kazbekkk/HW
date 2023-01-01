/* Генерируется случайное целое число n в интервале [ 20 – 99 ].
Проверяется, делится ли оно на введенное с клавиатуры целое число d
(используйте тернарный оператор). */

Console.Clear();

Random n = new Random(); int d;

int Num = n.Next(20, 100); // рандомное число
Console.Write("Введите число: ");
string D = Console.ReadLine();
if (!int.TryParse(D, out d)) // проверка числа
{
    Console.WriteLine("Не число"); d = 1;
}
    d = int.Parse(D);

string mes1 = (Num % d == 0)? $"Число {Num} делиться на {d}": $"Число {Num} не делится на {d}";
Console.Write(mes1);
Console.ReadKey();
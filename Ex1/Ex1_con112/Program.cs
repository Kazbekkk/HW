Console.Clear();
Random rnd = new Random(); // создаем экземпляр класса Random
// генерируем случайное целое число в интервале -40, 40
int n = rnd.Next(-40, 40); 
// используем тернарный оператор
string mes1 = (n >= 0) ? "Положительное" : "отрицательное";
string mes2 = (n % 2 == 0) ? "четное" : "нечетное";
Console.WriteLine("Число {0} {1} {2}", n, mes1, mes2);
Console.ReadKey();
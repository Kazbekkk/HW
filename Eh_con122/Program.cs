/* Генерируются два случайных целых числа a и b в интервале [10 – 30].
Если a > b, выводится их разность, eсли a < b, выводится сумма,
eсли a == b, выводится сообщение “числа равны”. */
Console.Clear();
Random A = new Random();


int Num1 = A.Next(10, 30);
Console.WriteLine("Первое сгенерированое число {0}", Num1);
int Num2 = A.Next(10,30);
Console.WriteLine("Второе сгенерированое число {0}", Num2);
if (Num1 > Num2) 
{
    int difference = Num1 - Num2;
    Console.WriteLine("Разность чисел {0} и {1} будет {2}", Num1, Num2, difference);
}
else if (Num1 < Num2)
{
    int total = Num1 + Num2;
    Console.WriteLine("Сумма чисел {0} и {1} равна {2}", Num1, Num2, total);
}
else if (Num1 == Num2)
{
    Console.WriteLine("Числа равны");
}
Console.ReadKey();
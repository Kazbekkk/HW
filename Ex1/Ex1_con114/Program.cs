Console.Clear();
// задаем эталонные логин и пароль, а также выводимые сообщения
string myLog = "qwerty", myPas = "asdf";
string mes = "", mesYes = "Добро пожаловать!", mesNo = "Вход воспрещен!";
Console.Write("Введите логин: ");
string log = Console.ReadLine(); // вводим логин
// проверяем длину и совпадение логина
if (log.Length < 6) mes = "Логин очень короткий!\n" + mesNo;
    else if (log != myLog) mes = "Неверный логин!\n" + mesNo;
        else
            // в случае истинности логина вводим и проверяем пароль
        {
            Console.WriteLine("Введите пароль: ");
            string pas = Console.ReadLine();
            mes = (pas == myPas)? mesYes : "Неверный пароль!\n" + mesNo;
        }
Console.WriteLine(mes);
Console.ReadKey();


/*В переменной string есть секретное сообщение, во второй есть пароль. 
Пользователю программы даётся 3 попытки ввести пароль и увидеть секретное сообщение.*/

Console.WriteLine("Введите пароль. У вас есть 3 попытки.");
string password1 = Console.ReadLine();


string password = "A35g!";
string password1 = password11.Replace(" ", "");
if (password1 == password)
{
    Console.WriteLine("Добро пожаловать!");
}
else
{
    Console.WriteLine("Вы ввели неверный пароль. Осталось две попытки. Попробуйте снова: ");
    string password2 = Console.ReadLine();

    if (password2 == password)
    {
        Console.WriteLine("Добро пожаловать!");
    }
    else
    {
        Console.WriteLine("Вы ввели неверный пароль. Осталась одна попытки. Попробуйте снова: ");
        string password3 = Console.ReadLine();

        if (password3 == password)
        {
            Console.WriteLine("Добро пожаловать!");
        }
        else
        {
            Console.WriteLine("К сожалению ваши попытки закончились. До свидания.");
        }
    }
}
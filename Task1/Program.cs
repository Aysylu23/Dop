/*В переменной string есть секретное сообщение, во второй есть пароль. 
Пользователю программы даётся 3 попытки ввести пароль и увидеть секретное сообщение.*/

/*Console.WriteLine("Введите пароль. У вас есть 3 попытки.");
string password1 = Console.ReadLine();


string password = "A35g!";

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
}*/


Console.WriteLine("У вас есть 3 попытки.");
string input_password = "A35g!";
string message = "Добро пожаловать!";
Console.WriteLine("Введите пароль: ");

for (int i = 1; i <= 3; i++)
{

    string password = Console.ReadLine();

    if (password == input_password)
    {
        Console.WriteLine($"{message}");
        break;
    }
    else
    {
        if (i < 3)
        {
            Console.WriteLine("Вы ввели неверный пароль. Попробуйте снова: ");
        }
        else
        {
            Console.WriteLine("К сожалению, ваши попытки закончились.");
        }
    }
}
/*Eсть программа с бесконечным циклом. 
Когда пользователь вводит exit программа заканчивается*/


/*Console.Write("Введите слово: ");

string word = Console.ReadLine();

for(; ;)
{
    Console.Write("hello");
    if(word == "exit")
    {
        break;
    }
}*/


string someMsg = ReadInput("Введите кодовое слово: ");
string acsessCode = "exit";

while (someMsg != acsessCode)
{
    someMsg = ReadInput("Введите кодовое слово: ");
}


// Функция ввода
string ReadInput(string msg)
{
    Console.Write(msg);
    return Console.ReadLine();
}   










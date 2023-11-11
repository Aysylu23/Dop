/*Eсть программа с бесконечным циклом. 
Когда пользователь вводит exit программа заканчивается*/


Console.Write("Введите слово: ");

string word = Console.ReadLine();

for(; ;)
{
    Console.Write("hello");
    if(word == "exit")
    {
        break;
    }
}












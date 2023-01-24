//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да

System.Console.WriteLine("Введите пятизначное число: ");
string text = Convert.ToString(Console.ReadLine());
int num1 = Convert.ToInt32(text[0]);
int num2 = Convert.ToInt32(text[1]);
int num4 = Convert.ToInt32(text[3]);
int num5 = Convert.ToInt32(text[4]);
if (num1 == num5 && num2 == num4)
{

    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");
}


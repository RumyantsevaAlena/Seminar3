// Задача 23. Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

System.Console.WriteLine("Введите число: ");
int numb = Convert.ToInt32(Console.ReadLine());
double answer = 0;

if (numb > 0)

    for (int i = 1; i <= numb; i++)
    {
        answer = Math.Pow(i, 3);
        System.Console.WriteLine(answer);
    }
else
{
    System.Console.WriteLine("Некорректное число");
}

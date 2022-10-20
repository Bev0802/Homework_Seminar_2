/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите целое число от 1 до 7");

int num = Convert.ToInt32(Console.ReadLine());

//Функция определяющая выходной день.
void Checkweekend(int number)
{
    if (number < 0 || number > 5)
    {
        Console.WriteLine("Да, это выходной день. УРА!!!!");
    }
    else
    {
        Console.WriteLine("Нет, это рабочий день.");
        return;
    }
}


//проверка числа на корректность.
if (num < 1 || num > 7)
{

    Console.Write("Ошибка! Вы ввели не верное число. В неделе тольок семь дней.");
    return;
    
}
else Console.Write($"Проверим, является ли оно выходным. ");


Checkweekend(num);


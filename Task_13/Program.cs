/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

//Функции 
int SearchthirdDigit(int number)
{
    int firstDigit = (number / 100) * 100;
    int thirdDigit = number % 100;
    int secondDigit = ((number - firstDigit - thirdDigit)/10);
    return thirdDigit;
}

//Тело программы

Console.WriteLine("Введите целое положительное число:");
int num = Convert.ToInt32(Console.ReadLine());

int thirdDigit = SearchthirdDigit(num);
Console.Write($"Вторая цифра числа {num}: {thirdDigit}");
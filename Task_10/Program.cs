/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

//Функция
int SearchsecondDigit(int number)
{
    int firstDigit = (number / 100) * 100;
    int thirdDigit = number % 10;
    int secondDigit = ((number - firstDigit - thirdDigit)/10);
    return secondDigit;
}


//Тело Программы

Console.WriteLine("Введите трехзначное целое положительное число:");
int num = Convert.ToInt32(Console.ReadLine());

if ((num / 100) > 0)
{
Console.WriteLine ($"Вы вели число {num}.");
}
else
{
    Console.WriteLine("Не верно, нужно ввести трехзначное число.");
    return;
} 

int secondDigit = SearchsecondDigit(num);
Console.Write($"Вторая цифра числа {num}: {secondDigit}");


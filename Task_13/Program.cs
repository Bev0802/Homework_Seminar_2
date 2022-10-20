/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine("Введите целое число:");
int num = Convert.ToInt32(Console.ReadLine());
int thirdDigit = num;
//Фукция
int SearchthirdDigit(int number)
{
    int thirdDigit = number % 10;
    return thirdDigit;
}

//Тело программы////////////////////

//Проверка на наличее третьей цифры.
if ((num / 100) > 0)
{
    Console.WriteLine($"Вы вели число {num}. Найдем третью цифру!");

}
else
{
    Console.WriteLine("В этом чиле третьей цифры нет!");
}

//Приведение числа в трехзначное.
while ((thirdDigit / 1000) != 0)
{
    thirdDigit = num / 10;
    num = thirdDigit;
}

//Выведение на печать тетьей
int result = SearchthirdDigit(thirdDigit);
Console.WriteLine(result);
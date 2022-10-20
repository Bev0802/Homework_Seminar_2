/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine("Введите целое число:");
int num = Convert.ToInt32(Console.ReadLine());
num = Math.Abs(num);
int thirdDigit = num;
//Фукция которая находит третье число из любого целого положительного числа.
int SearchthirdDigit(int number)
{
    int thirdDigit = number;
    while ((thirdDigit / 1000) != 0)
{
    thirdDigit = number / 10;
    number = thirdDigit;
}
    thirdDigit = number % 10;
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
    return;   
}



//Выведение на печать тетьей
int result = SearchthirdDigit(thirdDigit);
Console.WriteLine(result);
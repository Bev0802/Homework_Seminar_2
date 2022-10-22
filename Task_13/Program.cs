/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine("Введите целое положительное число:");
int num = Convert.ToInt32(Console.ReadLine());

//проверка на отрицательное (замечание преподавателя))
if (num < 0) {Console.WriteLine("Вы ввели отрицательное число, но мы это иправим");}
num = Math.Abs(num);

//int thirdDigit = num;
//Фукция которая находит третье число из любого целого положительного числа.
//в соответсвии с предложением преподавателя
int SearchthirdDigit(int number)
{
while (number / 1000 != 0)
{
number = number / 10;
}
return number % 10;
}
//мая
/* int SearchthirdDigit(int number)
{
    int thirdDigit = number;
    while ((thirdDigit / 1000) != 0)
{
    thirdDigit = number / 10;
    number = thirdDigit;
}
    thirdDigit = number % 10;
    return thirdDigit;
} */

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
int result = SearchthirdDigit(num);
Console.WriteLine(result);
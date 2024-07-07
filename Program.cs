// принимает на вход трехзначное число и убирает вторую цифру



/* System.Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 99 && number < 1000)
{
    
    int result = number / 100 * 10 + number % 10;
    System.Console.WriteLine(result);

}
else
{
    System.Console.WriteLine("Вы ввеели не трехначное число");
}
*/

// Написать программу, которая принимает на вход трехзначное число и возводит вторую цифру в степень равную третьей цифре

/* System.Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 99 && number < 1000)
{
    
    int digit = number / 10 % 10;
    int result = 1;
    for ( int power = number % 10; power > 0; power--)
    {
        result *= digit; // result = result * digit
    }
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("Вы ввеели не трехначное число");
}
*/

// программа, которая будет принимать на вход 2 числа и выводить, является ли первое число кратным второму. Если первое число некратно второму, то программа выводит остаток от деления

// System.Console.WriteLine("Введите первое число");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число");
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// if(firstNumber % secondNumber == 0)
// {
//     System.Console.WriteLine("Да");
// }
// else {
//     System.Console.WriteLine("Нет", firstNumber % secondNumber);
// }

// Выводит третью цифру с конца или сообщает, что третьей цифры нет

// System.Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 99)
// {
//     System.Console.WriteLine(number % 1000 / 100);
// }
// else
//     System.Console.WriteLine("Третьей цифры нет");


// System.Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 99)
// {
//     while(number > 999)
//         number /= 10;
//     System.Console.WriteLine(number % 10);
// }
// else
//     System.Console.WriteLine("Третьей цифры нет");
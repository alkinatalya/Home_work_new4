/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
 и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);
void NaturalDegreeNumber(int number1, int number2)
{
    int result = 1;
    if (number2 > 0)
    {
        if (number2 == 1)
        {
            System.Console.WriteLine($"Число {number1} в степени {number2} => {number1}");
        }
        else
        {
            for (int index = 1; index < number2 + 1; index++)
            {
                result = result * number1;
            }
            System.Console.WriteLine($"Число {number1} в степени {number2} => {result}");
        }

    }
    else
    {
        System.Console.WriteLine("Второе число должно быть натуральным");
    }
}
NaturalDegreeNumber(number1,number2);
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int get_number(string message)
{
    Console.Write(message);
    int rez = Convert.ToInt32(Console.ReadLine());
    return rez;
}
int get_sum_of_num(int num)
{
    int summa =0;
    while (num>0)
    {
        summa=summa+num%10;
        num=num/10;
    }
    return summa;
}
int number = get_number("Введите число: ");
Console.WriteLine(get_sum_of_num(number));
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int get_number(string message)
{
    Console.Write(message);
    int rez = Convert.ToInt32(Console.ReadLine());
    return rez;
}
int calc(int first_num, int second_num)
{
    int rez=1;
    if (second_num>0)
    {
        while (second_num>0)
        {
            rez=first_num*rez;
            second_num--;
        }    
    }
    else
    {
        while (second_num<0)
        {
            rez=rez/first_num;
            second_num++;
        }    
    }
    return rez;
}
int num1=get_number("Введите первое число: ");
int num2=get_number("Введите второе число: ");
Console.WriteLine(calc(num1,num2));

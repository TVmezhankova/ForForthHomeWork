// Программа принимает на вход число и выдает 
// сумму цифр в числе.

System.Console.WriteLine("Введите число :");
int num = int.Parse(Console.ReadLine());
int N = num;
int Sum = 0;
while (num>10)
{
    Sum=Sum+num%10;
    num=num/10;
}
 Sum=Sum+ num;
 System.Console.WriteLine($"Сумма цифр числа {N} равна {Sum}");
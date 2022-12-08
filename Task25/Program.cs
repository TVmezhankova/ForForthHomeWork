// Написать цикл, который принимает на вход 2 числа (А и В)
// и возводит число в натуральную степень В.

System.Console.WriteLine("Введите число А:");
int A = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите число B - показатель степени:");
int B = int.Parse(Console.ReadLine());

int count = 1;
int result = 1;
while ( count<=B)
 {
    result=result*A;
    count=(count+1);
 }
    System.Console.WriteLine($"число {A} в степени {B} равно {result}");
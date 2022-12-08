//Пользователь вводит массив из 8 элементов и программа
// выводит их на экран.
Console.WriteLine("Введите количество элементов массива");
int N = int.Parse(Console.ReadLine());
int[] arr=new int[N];
for(int j =0; j < arr.Length; j=j+1)
{
    Console.WriteLine($"Введите элемент массива с индексом {j}");
    arr[j] = int.Parse(Console.ReadLine());
}
 Console.WriteLine("Вывод массива");
 for (int j=0;j<arr.Length; j=j+1)
 {
    Console.WriteLine(arr[j]);
 }
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*double Work(double a, double b)
{
    double work = Math.Pow(a, b);
    return work;
}
Console.WriteLine("Input a first number: ");
double n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second number: ");
double n2 = Convert.ToInt32(Console.ReadLine());
double res = Work(n, n2);
Console.WriteLine($"Yoyr result {res}");
*/
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*int Sum(int n)
{
    int sum = 0;
    while(n > 0)
    {
        int number = n % 10;
        n = n / 10;
        sum = number + sum;
    }
    return sum;
}
Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = Sum(num);
Console.WriteLine($"Your sum number {res}");
*/
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33 -> [6, 1, 33]
/*int[] array = new int[8];
for(int i = 0; i < array.Length; i++)
{
    Console.Write("Введите число : ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Вывод массива:  ");
Console.Write("[");
for(int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + ",");
}
Console.Write("]");
*/








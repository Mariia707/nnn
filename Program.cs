//  Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.
// 3,5 -> 243
// 2,4 -> 16

int St(int s, int g){
    int p = 1;
    for (int i = 1; i<=g; i++)
    {
        p = p * s;
    }
    return p;
}

Console.WriteLine("Введите число а ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{St(a,b)}");


// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе
// 452 -> 111
// 82 -> 10
// 9012-> 12

// int Summ(int numb){
    
//     int a = 0;
//     int n = 0;
    
//     while (numb >0){
//         n = numb % 10;
//         a = a + n;
//         numb = numb / 10;
//     }
    
//     return a;
// }

// Console.WriteLine("Введите число ");

// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Summ(b));

// Напишите программу, которая задает массив из 8 элементов и выводит их на экран
// 1,2,5,7,19 -> [1.2.5.7.19]
// 6,1,33 -> [6.1.33]



// int[] arr = new int [8];

// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = new Random().Next(100);
//     Console.Write($"{arr [i]}, " );
// }
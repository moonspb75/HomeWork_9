// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Summ(int m, int n )
 {
     if(n == m)
     {
         return m;
     }
     
     return n + Summ(m, n - 1); 
 }

 System.Console.Write("Введите число min: ");
 int summMin = Convert.ToInt32(Console.ReadLine());
 System.Console.Write("Введите число max: ");
 int summMax = Convert.ToInt32(Console.ReadLine());
 System.Console.WriteLine($"{Summ(summMin, summMax)}");
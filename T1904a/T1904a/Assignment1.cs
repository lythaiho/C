using System;

namespace T1904a
{
    public class Assignment1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment 1 running ...");
            Console.WriteLine("Nhap n so de kiem tra:");
            int n = Convert.ToInt32(Console.ReadLine());
            CheckFibonacci(n);
        }
        static void CheckFibonacci(int n)
        {
             int n1 = 0;
             int n2 = 1;
             int n3 = 1;
            for (int i = 0; i < n; i++)
            {
                while ((n2+n1 )< n)
                {
                    n3 = n1 + n2;  
                    n1 = n2;  
                    n2 = n3;
                }
                Console.WriteLine("So fibonacci gan nhat");
                    Console.WriteLine(n3); break;
            }
        }
    }
}
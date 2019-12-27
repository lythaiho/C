using System;

namespace T1904a
{
    public class Prime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime running ...");
            Console.WriteLine("Nhap 1 so de kiem tra");
            int n = Convert.ToInt32(Console.ReadLine());
            if (checkPrime(n))
            {
                Console.WriteLine(n+"la so nguyen to");
                
            }
            else
            {
                Console.WriteLine(n+"Khong phai so nguyen to");
            }
        }

        static bool checkPrime(int n)
        {
            if (n < 2) return false;
            if (n < 4) return true;
            for (int i = 2; i <= n/2; i++)
            {
                if (n % i == 0) return false;\
            }

            return true;
        }
    }
}
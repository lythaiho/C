using System;

namespace T1904a
{
    public class SoNguyenTo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("So Nguyen To Running....");
            int n = Convert.ToInt32(Console.ReadLine());
            checkSoNguyenTo(n);
        }

        static void checkSoNguyenTo(int n)
        {
            if (n < 2)
            {
                Console.WriteLine("Khong phai so nguyen to");
            }

            if (n == 2)
            {
                Console.WriteLine("So 2 la so nguyen to");
            }

            if (n > 2)
            {
                int temp = 1;
                for (int i = 0; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        temp++;
                    }
                }

                if (temp == 2)
                {
                    Console.WriteLine("So %d la so nguyen to",n);
                }
                else
                {
                    Console.WriteLine("So %d khong phai so nguyen to",n);
                }
            }
            
        }
    }
}
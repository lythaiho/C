using System;
using System.Collections.Generic;
using T1904a;

namespace T1904a
{
    public class Session2
    {
        static void Main(string[] args)
        {
            Human h= new Human();
            h.SayHello();
            h.SayHello("Anna");
            Asian a= new Asian();
            a.SayHello();
            a.Jumping();
            h.Age = 12;
            Console.WriteLine("Tuoi:  "+h.Age);
            h.Age = -1;
            Console.WriteLine("Tuoi 2:  "+h.Age);
            a.telephone[0] = "0987654321";
            a.telephone[1] = "0123456789";
            a[2] = "012412471";
            a[3] = "7823642";
            Console.WriteLine("Chi muc 1:  "+a[1]);
            List<string> strList = new List<string>();
            strList.Add("aaa");
            strList[1] = "bb";
        }
    }
}
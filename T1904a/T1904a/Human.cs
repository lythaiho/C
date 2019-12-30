using System;

namespace T1904a
{
    public class Human
    {
        private String name;
        private int age;

        public Human()
        {
            Console.WriteLine("Constructors");
        }

        public void SayHello()
        {
            Console.WriteLine("Hello World");
        }

        public string Name
        {
            get { return name;}
            set { this.name = value; }
        }

        public int Age
        {
            get
            {
                if (age <= 1) return 1;
                return age;
            }
            set
            {
                if (value <= 1)
                {
                    this.age = 1;
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public void SayHello(String msg)
        {
            Console.WriteLine("Hello"+msg);
        }

        public virtual void Running()
        {
            Console.WriteLine("Running ...");
        }

        public void Jumping()
        {
            Console.WriteLine("Jumping ....");
        }
    }
}
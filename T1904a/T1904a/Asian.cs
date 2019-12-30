using System;

namespace T1904a
{
    public class Asian : Human, IHuman
    {
        public string[] telephone = new string[5];

        public string this[int index]
        {
            get { return telephone[index]; }
            set { telephone[index] = value; }
        }
        public override void Running()
        {
            base.Running();
            Console.WriteLine("Asian Running ...");
        }

        public new void Jumping()
        {
            Console.WriteLine("Asian Jumping ....");
        }

        public void Shoopping()
        {
            
        }

        public void Driver()
        {
            
        }
    }
}
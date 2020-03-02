using System;

namespace T1904a.Patical
{
    public class Phone
    {
        protected string phoneName;
        protected string phoneType;
        protected float phonePrice;

        public Phone()
        {
        }

        public Phone(string phoneName, string phoneType, float phonePrice)
        {
            this.phoneName = phoneName;
            this.phoneType = phoneType;
            this.phonePrice = phonePrice;
        }

        public void inputPhone()
        {
            Console.WriteLine("PhoneName : ");
            phoneName = Console.ReadLine();
            Console.WriteLine("PhoneType : ");
            phoneType = Console.ReadLine();
            Console.WriteLine("PhonePrice : ");
            phonePrice = Convert.ToByte(Console.ReadLine());
        }

        public void outPut()
        {
            Console.WriteLine("Phone"+phoneName+"type"+phoneType+"price"+phonePrice);
        }
    }
    
}
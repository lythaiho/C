namespace T1904a.Patical
{
    public delegate void PrimeNumberFinder(int s);
    public class Delegates
    {
        public event PrimeNumberFinder OnPrimeNumber;

        static void Main(string[] args)
        {
            PrimeNumberFinder pf =new PrimeNumberFinder(Numbers);
        }
        public static void Number
    }
}
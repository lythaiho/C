namespace T1904a.Patical
{
    public class Start
    {
        public static void Main(string[] args)
        {
         
            Phone tP = new Phone("DuyCode","Vinaphone",12345678);
            MobilePhone Tmobile = new MobilePhone();
            tP.outPut();
            Tmobile.outPut();
        }
    }
}
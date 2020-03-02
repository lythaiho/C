using System.Collections.Generic;

namespace T1904a.Patical
{
    public class MobilePhone : Phone
    {
        public MobilePhone()
        {
            this.phoneType ="mMbile";
        }

        public MobilePhone(string phoneName, string phoneType, float phonePrice)
        {
            this.phoneName = phoneName;
            this.phoneType = "Mobile";
            this.phonePrice = phonePrice;
        }
    }
    
}
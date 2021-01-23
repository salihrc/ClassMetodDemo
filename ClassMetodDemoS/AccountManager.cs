using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetodDemoS
{
    class AccountManager
    {
        public void AccountMoneyAdd(int hesaptaolan, int eklenenpara)
        {
            hesaptaolan = hesaptaolan + eklenenpara;
            Console.WriteLine("Hesaba " + eklenenpara + "tl eklendi." + "Yeni Bakiyeniz :\n " + hesaptaolan);
        }
    }
}

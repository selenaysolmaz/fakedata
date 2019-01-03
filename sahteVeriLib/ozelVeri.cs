using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sahteVeriLib
{
    class ozelVeri
    {
        public string[] ozelAd = { "sema", "ferhat", "kübra", "selenay", "ismet" };
        public string[] renk = { "siyah", "beyaz", "mor", "kırmızı", "sarı", "mavi", "yeşil" };
        public int[] yas = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        Random rnd = new Random();
        public string OzelAd() 
        {
            int ad = rnd.Next(0, 4);
            return ozelAd[ad];
            
        }
        public string Renk()
        {
            int x = rnd.Next(0, 6);
            return renk[x];

        }

        public int Yas()
        {
            int y = rnd.Next(0, 19);
            return yas[y];

        }
    }
}

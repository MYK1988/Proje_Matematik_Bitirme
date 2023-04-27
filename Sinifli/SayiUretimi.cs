using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinifli
{
    public class SayiUretimi
    {
        public static int IkiBasamakliSayiUret(int x)
        {
            Random r = new Random();
            return x = r.Next(-99, 100);
        }
        public static int UcBasamakliSayiUret(int x)
        {
            Random r = new Random();
            return x = r.Next(-999, 1000);
        }

        public static int DortBasamakliSayiUret(int x)
        {
            Random r = new Random();
            return x = r.Next(-9999, 10000);
        }
    }
    public class SeviyeNo
    {
        public static int BirinciSeviye(int x)
        {
            Random r= new Random();
            return x = r.Next(1,3);
        }
        public static int IkinciSeviye(int x)
        {
            Random r = new Random();
            return x = r.Next(1, 5);
        }
        public static int UcuncuSeviye(int x)
        {
            Random r = new Random();
            return x = r.Next(1, 6);
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinifli
{
    public class MatematikselIslemler
    {
        public static int Toplama(int x, int y)
        {
            return x + y;
        }

        public static int Cikarma(int x, int y)
        {
            return x - y;
        }

        public static int Carpma(int x, int y)
        {
            return x * y;
        }

        public static int Bolme(int x, int y)
        {
            return x / y;
        }

        public static int Mod(int x, int y)
        {
            return x % y;
        }
    }
}

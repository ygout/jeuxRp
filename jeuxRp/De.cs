using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeuxRp
{
    static class De
    {
        static private Random random = new Random();

        static public int Rolled()
        {
            return random.Next(1, 7);
        }
    }
}

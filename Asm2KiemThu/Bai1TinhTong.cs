using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Asm2KiemThu
{
    public class Bai1TinhTong
    {
        public int? TinhTong(object a, object b)
        {
            if (a is int intA && b is int intB)
            {
                checked
                {
                    return intA + intB;
                }
            }
            return null;
        }
    }
}

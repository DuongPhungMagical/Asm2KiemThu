using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm2KiemThu
{
    public class Bai3TinhTich
    {
        public int? TinhTich(object a, object b)
        {
            if (a is int intA && b is int intB)
            {
                checked
                {
                    return intA * intB;
                }
            }
            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm2KiemThu
{
    public class Bai5Mang
    {
        public object TruyXuat(object[] array, int index)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array), "mang khong duoc null");

            if (index < 0 || index >= array.Length)
                throw new IndexOutOfRangeException("index ngoai mang");

            return array[index];
        }
    }
}

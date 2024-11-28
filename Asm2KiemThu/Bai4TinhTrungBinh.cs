using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm2KiemThu
{
    public class Bai4TinhTrungBinh
    {
        public double? TinhTrungBinh(List<double> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                return null;
            }

            double sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum / numbers.Count;
        }
    }
}

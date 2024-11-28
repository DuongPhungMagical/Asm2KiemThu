using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm2KiemThu.Bai6SinhVien
{
    public class SinhVienPoly
    {
        private readonly List<SinhVien> _sinhVienList = new();

        public void ThemSinhVien(SinhVien sv)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(sv.TenLop, "^[a-zA-Z0-9 ]+$"))
            {
                throw new ArgumentException("Tên lớp chứa ký tự đặc biệt.");
            }
            _sinhVienList.Add(sv);
        }

        public List<SinhVien> TimTheoTen(string hoTen)
        {
            return _sinhVienList.Where(sv => sv.HoTen.Equals(hoTen, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public SinhVien TimTheoMaSv(string maSv)
        {
            return _sinhVienList.FirstOrDefault(sv => sv.MaSv.Equals(maSv, StringComparison.OrdinalIgnoreCase));
        }
    }
}

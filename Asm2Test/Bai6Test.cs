using Asm2KiemThu.Bai6SinhVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm2Test
{
    [TestFixture]
    internal class Bai6Test
    {
        private SinhVienPoly svPoly;

        [SetUp]
        public void Setup()
        {
            svPoly = new SinhVienPoly();
        }

        [Test]
        public void Test1()
        {
            var sv = new SinhVien("1", "Nguyen Van A", "ML01", "CNTT", "SV01");
            Assert.DoesNotThrow(() => svPoly.ThemSinhVien(sv)); 
        }

        [Test]
        public void Test2()
        {
            var sv = new SinhVien("2", "Nguyen Van B", "ML02", "CN@TT", "SV02");
            Assert.Throws<ArgumentException>(() => svPoly.ThemSinhVien(sv)); 
        }

        [Test]
        public void Test3()
        {
            var sv = new SinhVien("3", "Nguyen Van C", "ML03", "", "SV03");
            Assert.Throws<ArgumentException>(() => svPoly.ThemSinhVien(sv)); 
        }

        [Test]
        public void Test4()
        {
            var sv = new SinhVien("4", "Nguyen Van D", "ML04", "Cong Nghe Thong Tin", "SV04");
            Assert.DoesNotThrow(() => svPoly.ThemSinhVien(sv)); 
        }

        [Test]
        public void Test5()
        {
            var sv = new SinhVien("5", "Nguyen Van E", "ML05", new string('A', 100), "SV05");
            Assert.DoesNotThrow(() => svPoly.ThemSinhVien(sv)); 
        }

        [Test]
        public void Test6()
        {
            var sv = new SinhVien("6", "Nguyen Van F", "ML06", "A", "SV06");
            Assert.DoesNotThrow(() => svPoly.ThemSinhVien(sv)); 
        }

        [Test]
        public void Test7()
        {
            var sv = new SinhVien("7", "Nguyen Van G", "ML07", "@CNTT", "SV07");
            Assert.Throws<ArgumentException>(() => svPoly.ThemSinhVien(sv)); 
        }

        [Test]
        public void Test8()
        {
            var sv = new SinhVien("8", "Nguyen Van H", "ML08", "CNTT@", "SV08");
            Assert.Throws<ArgumentException>(() => svPoly.ThemSinhVien(sv)); 
        }

        [Test]
        public void Test9()
        {
            var sv = new SinhVien("9", "Nguyen Van I", "ML09", "Công Nghệ Thông Tin", "SV09");
            Assert.DoesNotThrow(() => svPoly.ThemSinhVien(sv)); 
        }

        [Test]
        public void Test10()
        {
            var sv = new SinhVien("10", "Nguyen Van J", "ML10", "12345", "SV10");
            Assert.DoesNotThrow(() => svPoly.ThemSinhVien(sv)); 
        }
        ////////////////tim kiem
        ///
        [Test]
        public void TestTimTheoMaSv_Found()
        {
            var result = svPoly.TimTheoMaSv("SV01");
            Assert.NotNull(result);
            Assert.AreEqual("Nguyen Van A", result.HoTen);
        }

        [Test]
        public void TestTimTheoMaSv_NotFound()
        {
            var result = svPoly.TimTheoMaSv("SV99");
            Assert.IsNull(result);
        }

        [Test]
        public void TestTimTheoMaSv_EmptyMaSv()
        {
            var result = svPoly.TimTheoMaSv("");
            Assert.IsNull(result);
        }

        [Test]
        public void TestTimTheoMaSv_InvalidMaSvFormat()
        {
            var result = svPoly.TimTheoMaSv("sv_01");
            Assert.IsNull(result);
        }

        [Test]
        public void TestTimTheoMaSv_CaseInsensitive()
        {
            var result = svPoly.TimTheoMaSv("sv01"); // Kiểm tra tìm kiếm không phân biệt chữ hoa thường
            Assert.NotNull(result);
            Assert.AreEqual("Nguyen Van A", result.HoTen);
        }
    }
}

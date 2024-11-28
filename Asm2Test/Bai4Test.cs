using Asm2KiemThu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm2Test
{
    [TestFixture]
    public class Bai4Test
    {
        private Bai4TinhTrungBinh _tinhTrungBinh;

        [SetUp]
        public void Setup()
        {
            _tinhTrungBinh = new Bai4TinhTrungBinh();
        }

        // Test Case 1: Danh sách hợp lệ với các số dương
        [Test]
        public void Test1()
        {
            var numbers = new List<double> { 10, 20, 30, 40, 50 };
            var result = _tinhTrungBinh.TinhTrungBinh(numbers);
            Assert.AreEqual(30, result);
        }


        [Test]
        public void Test2()
        {
            var numbers = new List<double>();
            var result = _tinhTrungBinh.TinhTrungBinh(numbers);
            Assert.IsNull(result);
        }


        [Test]
        public void Test3()
        {
            var result = _tinhTrungBinh.TinhTrungBinh(null);
            Assert.IsNull(result);
        }

    }
}

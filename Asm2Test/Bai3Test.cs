using Asm2KiemThu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm2Test
{
    [TestFixture]
    public class Bai3Test
    {
        private Bai3TinhTich _tinhTich;
        [SetUp]
        public void Setup()
        {
            _tinhTich = new Bai3TinhTich();
        }
        [Test]
        public void Test1()
        {
            int? result = _tinhTich.TinhTich(10, 20);
            Assert.AreEqual(30, result);
        }
        [Test]
        public void Test2()
        {
            int? result = _tinhTich.TinhTich("abc", 3);
            Assert.IsNull(result);
        }
        [Test]
        public void Test3()
        {
            int? result = _tinhTich.TinhTich("abc", "111");
            Assert.IsNull(result);
        }
        [Test]
        public void Test4()
        {
            Assert.Throws<OverflowException>(() => _tinhTich.TinhTich(int.MaxValue, 1));
        }
        [Test]
        public void Test5()
        {
            Assert.Throws<OverflowException>(() => _tinhTich.TinhTich(int.MinValue, -1));
        }
        [Test]
        public void Test6()
        {
            int? result = _tinhTich.TinhTich(int.MaxValue - 1, 1);
            Assert.AreEqual(int.MaxValue, result);
        }
        [Test]
        public void Test7()
        {
            int? result = _tinhTich.TinhTich(1, new object());
            Assert.IsNull(result);
        }
        [Test]
        public void Test8()
        {
            int? result = _tinhTich.TinhTich(0, 20);
            Assert.AreEqual(0, result);
        }
        [Test]
        public void Test9()
        {
            int? result = _tinhTich.TinhTich(-5, 5);
            Assert.AreEqual(-25, result);
        }
        [Test]
        public void Test10()
        {
            int? result = _tinhTich.TinhTich(-1, -1);
            Assert.AreEqual(-1, result);
        }
    }
 }

using Asm2KiemThu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm2Test
{
    [TestFixture]
    internal class Bai2Test
    {
        private Bai2TinhHieu _tinhHieu;
        [SetUp]
        public void Setup()
        {
            _tinhHieu = new Bai2TinhHieu();
        }
        [Test]
        public void Test1()
        {
            int? result = _tinhHieu.TinhHieu(10, 20);
            Assert.AreEqual(30, result);
        }
        [Test]
        public void Test2()
        {
            int? result = _tinhHieu.TinhHieu("abc", 3);
            Assert.IsNull(result);
        }
        [Test]
        public void Test3()
        {
            int? result = _tinhHieu.TinhHieu("abc", "111");
            Assert.IsNull(result);
        }
        [Test]
        public void Test4()
        {
            Assert.Throws<OverflowException>(() => _tinhHieu.TinhHieu(int.MaxValue, 1));
        }
        [Test]
        public void Test5()
        {
            Assert.Throws<OverflowException>(() => _tinhHieu.TinhHieu(int.MinValue, -1));
        }
        [Test]
        public void Test6()
        {
            int? result = _tinhHieu.TinhHieu(int.MaxValue - 1, 1);
            Assert.AreEqual(int.MaxValue, result);
        }
        [Test]
        public void Test7()
        {
            int? result = _tinhHieu.TinhHieu(1, new object());
            Assert.IsNull(result);
        }
        [Test]
        public void Test8()
        {
            int? result = _tinhHieu.TinhHieu(0, 20);
            Assert.AreEqual(20, result);
        }
        [Test]
        public void Test9()
        {
            int? result = _tinhHieu.TinhHieu(-5, 5);
            Assert.AreEqual(30, result);
        }
        [Test]
        public void Test10()
        {
            int? result = _tinhHieu.TinhHieu(-1, -1);
            Assert.AreEqual(30, result);
        }
    }
}

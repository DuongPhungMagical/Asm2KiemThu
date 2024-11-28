using Asm2KiemThu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm2Test
{
    internal class Bai5Test
    {
        [TestFixture]
        public class ArrayHandlerTests
        {
            private Bai5Mang _truyXuat;

            [SetUp]
            public void Setup()
            {
                _truyXuat = new Bai5Mang();
            }

            // Test Case 1: Truy xuất phần tử hợp lệ
            [Test]
            public void GetElementAtIndex_ValidIndex_ReturnsCorrectElement()
            {
                var array = new object[] { "A", "B", "C", "D" };
                var result = _truyXuat.TruyXuat(array, 2);
                Assert.AreEqual("C", result);
            }

            // Test Case 2: Truy xuất phần tử tại index âm
            [Test]
            public void GetElementAtIndex_NegativeIndex_ThrowsIndexOutOfRangeException()
            {
                var array = new object[] { "A", "B", "C", "D" };
                Assert.Throws<IndexOutOfRangeException>(() => _truyXuat.TruyXuat(array, -1));
            }

            // Test Case 3: Truy xuất phần tử tại index vượt quá giới hạn
            [Test]
            public void GetElementAtIndex_IndexOutOfRange_ThrowsIndexOutOfRangeException()
            {
                var array = new object[] { "A", "B", "C", "D" };
                Assert.Throws<IndexOutOfRangeException>(() => _truyXuat.TruyXuat(array, 4));
            }
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ImplementacjaTime.Tests
{
    [TestClass]
    public class TimeRelations
    {
        [DataTestMethod]
        [DataRow((byte)0, (byte)0, (byte)0, (byte)0, (byte)0, Byte.MinValue)]

        public void OperatorEqualsTo(byte b1, byte b2, byte b3, byte b4, byte b5, byte b6)
        {
            Time time1 = new Time(b1, b2, b3);
            Time time2 = new Time(b4, b5, b6);

            Assert.IsTrue(time1 == time2);

        }

        [DataTestMethod]
        [DataRow((byte)0, (byte)0, (byte)0, (byte)12, (byte)0, Byte.MinValue)]

        public void OperatorNotEqualsTo(byte b1, byte b2, byte b3, byte b4, byte b5, byte b6)
        {
            Time time1 = new Time(b1, b2, b3);
            Time time2 = new Time(b4, b5, b6);

            Assert.IsTrue(time1 != time2);

        }

        [DataTestMethod]
        [DataRow((byte)12, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0)]
        [DataRow((byte)12, (byte)5, (byte)0, (byte)12, (byte)0, (byte)0)]
        [DataRow((byte)12, (byte)5, (byte)5, (byte)12, (byte)5, (byte)0)]

        public void GreaterOperator(byte b1, byte b2, byte b3, byte b4, byte b5, byte b6)
        {
            Time time1 = new Time(b1, b2, b3);
            Time time2 = new Time(b4, b5, b6);

            Assert.IsTrue(time1 > time2);
        }

        [DataTestMethod]
        [DataRow((byte)12, (byte)0, (byte)0, (byte)13, (byte)0, (byte)0)]

        public void GreaterOperatorFalse(byte b1, byte b2, byte b3, byte b4, byte b5, byte b6)
        {
            Time time1 = new Time(b1, b2, b3);
            Time time2 = new Time(b4, b5, b6);

            Assert.IsFalse(time1 > time2);
        }
        [DataTestMethod]
        [DataRow((byte)12, (byte)0, (byte)0, (byte)10, (byte)0, (byte)0)]
        [DataRow((byte)12, (byte)0, (byte)0, (byte)12, (byte)0, (byte)0)]

        public void OperatorGreaterOrEquals(byte b1, byte b2, byte b3, byte b4, byte b5, byte b6)
        {
            Time time1 = new Time(b1, b2, b3);
            Time time2 = new Time(b4, b5, b6);

            Assert.IsTrue(time1 >= time2);
        }

        [DataTestMethod]
        [DataRow((byte)12, (byte)0, (byte)0, (byte)13, (byte)10, (byte)0)]

        public void OperatorGreaterOrEqualsFalse(byte b1, byte b2, byte b3, byte b4, byte b5, byte b6)
        {
            Time time1 = new Time(b1, b2, b3);
            Time time2 = new Time(b4, b5, b6);

            Assert.IsFalse(time1 >= time2);
        }

        [DataTestMethod]
        [DataRow((byte)12, (byte)0, (byte)0, (byte)13, (byte)0, (byte)0)]

        public void OperatorSmaller(byte b1, byte b2, byte b3, byte b4, byte b5, byte b6)
        {
            Time time1 = new Time(b1, b2, b3);
            Time time2 = new Time(b4, b5, b6);

            Assert.IsTrue(time1 < time2);
        }

        [DataTestMethod]
        [DataRow((byte)12, (byte)0, (byte)0, (byte)11, (byte)0, (byte)0)]

        public void OperatorSmallerFalse(byte b1, byte b2, byte b3, byte b4, byte b5, byte b6)
        {
            Time time1 = new Time(b1, b2, b3);
            Time time2 = new Time(b4, b5, b6);

            Assert.IsFalse(time1 < time2);
        }

        [DataTestMethod]
        [DataRow((byte)12, (byte)0, (byte)0, (byte)13, (byte)0, (byte)0)]
        [DataRow((byte)12, (byte)0, (byte)0, (byte)12, (byte)0, (byte)0)]

        public void OperatorSmallerOrEquals(byte b1, byte b2, byte b3, byte b4, byte b5, byte b6)
        {
            Time time1 = new Time(b1, b2, b3);
            Time time2 = new Time(b4, b5, b6);

            Assert.IsTrue(time1 <= time2);
        }

        [DataTestMethod]
        [DataRow((byte)12, (byte)0, (byte)0, (byte)11, (byte)10, (byte)0)]

        public void OperatorSmallerOrEqualsFalse(byte b1, byte b2, byte b3, byte b4, byte b5, byte b6)
        {
            Time time1 = new Time(b1, b2, b3);
            Time time2 = new Time(b4, b5, b6);

            Assert.IsFalse(time1 <= time2);
        }
    }
}
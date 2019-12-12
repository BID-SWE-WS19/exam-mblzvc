using NUnit.Framework;
using BID.SWE.EXAM.Impl;

namespace testproject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            CellPrinter cellPrinter = new CellPrinter();
            Assert.AreEqual("Cell rot born on 14.12.2019 is alive", cellPrinter.PrintState(true, new System.DateTime(2019, 12, 14).Date, "rot"));
        }
        [Test]
        public void Test2()
        {
            CellPrinter cellPrinter = new CellPrinter();
            Assert.AreEqual("Cell is on Position X:6 Y:7", cellPrinter.PrintPostion(6,7));
        }
    }
}
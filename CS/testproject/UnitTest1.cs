using NUnit.Framework;
using BID.SWE.EXAM.Impl;
using System;
using System.IO;
using System.Text;

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
        /* //BID.SWE1 kann nicht gefunden werden
        [Test]
        public void Test3()
        {
            AnotherCell cell = new AnotherCell();
            Assert.AreEqual(2, cell.Grow());
        }
        
        [Test]
        public void Test4()
        {
            AnotherCell cell = new AnotherCell();
            Assert.AreEqual(false, cell.IsAlive(1));
        }
        [Test]
        public void Test5()
        {
            AnotherCell cell = new AnotherCell();
            Assert.AreEqual(true, cell.IsAlive(2));
        }*/
        [Test]
        public void Test6()
        {
            Exercise3 ex3 = new Exercise3();
            Object[] arr = new Object[2];
            arr[0] = new Springen();
            arr[1] = new Laufen();
            Assert.AreEqual(arr, ex3.Method2());
        }
        [Test]
        public void Test7()
        {
            Exercise4 ex4 = new Exercise4();
            using (MemoryStream ms = new MemoryStream())
            {
                byte[] str = Encoding.UTF8.GetBytes("Frohe Weihnachten");
                byte[] intarr = BitConverter.GetBytes(42);
                byte[] boolarr = BitConverter.GetBytes(false);
                ms.Write(str, 0, str.Length);
                ms.Write(intarr, 0, intarr.Length);
                ms.Write(boolarr, 0, boolarr.Length);
                
                Assert.AreEqual(ms, ex4.Method1());
            }
        }
    }
}
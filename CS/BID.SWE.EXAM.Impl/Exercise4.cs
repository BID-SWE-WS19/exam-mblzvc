using System;
using System.IO;
using System.Text;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise4 : IExercise4
    {
        public object Method1()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                byte[] str = Encoding.UTF8.GetBytes("Frohe Weihnachten");
                byte[] intarr = BitConverter.GetBytes(42);
                byte[] boolarr = BitConverter.GetBytes(false);
                ms.Write(str, 0, str.Length);
                ms.Write(intarr, 0, intarr.Length);
                ms.Write(boolarr, 0, boolarr.Length);
                return ms;
            }
        }

        public object Method2(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
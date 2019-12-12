using System;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise3 : IExercise3
    {
        public object Method1()
        {
            return new AnotherMap();
        }

        public object Method2()
        {
            Object[] arr = new Object[2];
            arr[0] = new Springen();
            arr[1] = new Laufen();
            return arr;
        }

    }
}
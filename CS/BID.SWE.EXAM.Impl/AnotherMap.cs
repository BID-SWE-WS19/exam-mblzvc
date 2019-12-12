using System;
using BID.SWE1.Exam.Interfaces;
namespace BID.SWE.EXAM.Impl
{
    public class AnotherMap:Map
    {
        
        public AnotherMap()
        {
        }

        public override int AddNewCells(int count)
        {
            return count;
        }

        public override string GetMapName()
        {
            return "BID-Map";
        }

        public override float GetMapSize(float amount)
        {
            return amount * amount;
        }
    }
}

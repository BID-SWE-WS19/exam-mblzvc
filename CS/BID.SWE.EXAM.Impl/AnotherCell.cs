using System;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class AnotherCell : Cell
    {
        public AnotherCell()
        {
        }
        public override int Grow()
        {
            _size *= 2;
            return _size;
        }

        public bool IsAlive(int neighbours)
        {
            if (neighbours % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

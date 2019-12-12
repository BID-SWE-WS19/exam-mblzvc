using System;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class CellPrinter : ICellPrinter
    {
        public String PrintState(bool alive, DateTime date, String color)
        {
            if (alive)
            {
                return "Cell " + color + " born on " + date + "is alive";
            }
            else
            {
                return "Cell " + color + " born on " + date + "is dead";
            }
        }

        public string PrintPostion(int x, int y)
        {
            return "Cell is on Position X:" + x + " Y:" + y;
        }
    }
}

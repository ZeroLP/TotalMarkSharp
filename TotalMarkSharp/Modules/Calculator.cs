using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalMarkSharp.Modules
{
    class Calculator
    {
        public static int[] Calculate(int TotalOneMark, int TotalOneMarkANS, int TotalTwoMark, int TotalTwoMarkANS)
        {
            int TotalMark = TotalOneMarkANS + TotalTwoMarkANS;
            int TotalAvailable = TotalOneMark + TotalTwoMark;

            if (TotalMark > TotalAvailable) return null;

            return new int[] { TotalMark, TotalAvailable, (TotalMark / TotalAvailable) * 100};
        }
    }
}

    using System;
    using System.Collections.Generic;
    using System.Text;

namespace BethanyPieShopHRM
{
    internal class Utilities
    {   
        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
        {
            if (numberOfMonthsWorked == 12)
                return monthlyWage * (numberOfMonthsWorked + 1);
            return monthlyWage * numberOfMonthsWorked;
        }
    }
}

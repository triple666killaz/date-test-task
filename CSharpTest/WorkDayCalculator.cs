using System;
using System.Collections.Generic;
// using System.Linq;
using System.Text;
// using System.Threading.Tasks;

namespace CSharpTest
{
    public class WorkDayCalculator : IWorkDayCalculator
    {
        public DateTime Calculate(DateTime startDate, int dayCount, WeekEnd[] weekEnds)
        {
            if(weekEnds == null)
                return startDate.AddDays(dayCount-1);
            
            dayCount += GetTotalWeekEndsAmount(weekEnds);

            return startDate.AddDays(dayCount);
        }

        private int GetTotalWeekEndsAmount(WeekEnd[] weekEnds)
        {
            int amount = 0;

            foreach (var weekEnd in weekEnds)
                amount += (int)(weekEnd.EndDate - weekEnd.StartDate).TotalDays;
            
            return amount;
        }
    }
}

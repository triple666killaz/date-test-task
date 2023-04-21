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
            
            foreach (var weekEnd in weekEnds)
            {
                
                if(startDate.AddDays(dayCount) < weekEnd.StartDate)
                    break;
                
                if (weekEnd.StartDate.Equals(weekEnd.EndDate))
                {
                    dayCount += 1;
                    continue;
                }

                if (weekEnd.EndDate < startDate)
                    continue;
                
                dayCount += (int)(weekEnd.EndDate - weekEnd.StartDate).TotalDays;
                
            }
            
            return startDate.AddDays(dayCount);
        }
        
    }
}

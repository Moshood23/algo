using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo
{
    internal class Class8
    {
    }
}

   
   public class Ka
{
    public class TimeDifference;
    public static int ElapsedSeconds(DateTime startDate, DateTime endDate)
    {
        TimeSpan Difference = endDate - startDate;

        return (int)Difference.TotalSeconds;
    }
}

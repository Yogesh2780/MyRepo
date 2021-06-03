using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineTest.Business
{

    /// <summary>
    /// Generating series till the limit provided.
    /// </summary>
    public static class SeriesManager
    {
        public static List<int> GenerateSeries(int maxLength)
        {
            if (maxLength > 15)
            {
                return null;
            }
            List<int> series = new List<int>();
            int f1 = 1;
            int f2 = 1;
            int f3 = 1;

            series.Add(f1);
            series.Add(f2);
            series.Add(f3);

            for (var i =0; i<maxLength; i++)
            {
                int temp = f1 + f2 + f3;
                f1 = f2;
                f2 = f3;
                f3 = temp;
                series.Add(temp);
            }

            return series;
        }

        /// <summary>
        /// finding an item of series which is divisible by divident and in the nth position of series.
        /// </summary>
        /// <param name="divisor"></param>
        /// <param name="number"></param>
        public static int Search(int divisor, int position, int  seriesLength = 15 )
        {
            var series = GenerateSeries(seriesLength);

            if(divisor == 0)
            {
                return 0;
            }

            if(series != null && series.Count > 0)
            {
                int pos = 1;
                if(pos > position)
                {
                    return 0;
                }
                foreach(var item in series)
                {
                    if(item % divisor == 0)
                    {
                        if(pos == position)
                        {
                            return item;
                        }

                        pos++;
                    }
                }

                return 0; // not found
            }

            return 0;

        }

    }
}
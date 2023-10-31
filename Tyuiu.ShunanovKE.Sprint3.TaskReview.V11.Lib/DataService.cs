using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ShunanovKE.Sprint3.TaskReview.V11.Lib
{
    public class DataService : ISprint3Task7V11
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] res = new double[len];
            double y;
            int cnt = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (2-2*x == 0)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Cos(x) + (Math.Sin(x) / (2 - 2 * x)) - 4 * x;
                }
                res[cnt] = Math.Round(y, 2);
                cnt++;
            }
            return res;
        }
    }
}

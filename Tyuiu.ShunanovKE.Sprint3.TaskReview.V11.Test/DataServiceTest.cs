using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShunanovKE.Sprint3.TaskReview.V11.Lib;

namespace Tyuiu.ShunanovKE.Sprint3.TaskReview.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int start = -2, end = 2;
            double[] wait = new double[end - start + 1];
            wait[0] = 7.43;
            wait[1] = 4.33;
            wait[2] = 1;
            wait[3] = 0;
            wait[4] = -8.87;
            double[] res = ds.GetMassFunction(start, end);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}

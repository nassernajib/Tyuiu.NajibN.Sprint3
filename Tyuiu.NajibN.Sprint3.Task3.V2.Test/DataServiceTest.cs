using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NajibN.Sprint3.Task3.V2.Lib;
namespace Tyuiu.NajibN.Sprint3.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCharCount()
        {
            DataService ds = new DataService();

            string str = " asdzzz vfvfzz v gthvz";
            char chr = 'z';
            double res = ds.GetMaxCharCount(str, chr);
            int wait = 6;
            Assert.AreEqual(res, wait);
            {
            }
        }
    }
}

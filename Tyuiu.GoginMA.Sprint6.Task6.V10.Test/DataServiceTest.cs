using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GoginMA.Sprint6.Task6.V10.Lib;

namespace Tyuiu.GoginMA.Sprint6.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CollectTextFromFile()
        {
            string path = @"C:\Sprint6\InPutFileTask6V10.txt";

            DataService ds = new DataService();
            string res = ds.CollectTextFromFile(path);
            string wait = " nXkwQYzgZ LlckTwkpaAGTvLPc";
            Assert.AreEqual(wait, res);
        }
    }
}

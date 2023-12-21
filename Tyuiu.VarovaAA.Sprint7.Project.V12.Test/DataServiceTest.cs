using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.VarovaAA.Sprint7.Project.V12.Lib;
namespace Tyuiu.VarovaAA.Sprint7.Project.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\User\source\repos\Tyuiu.VarovaAA.Sprint7.Project.V12\Tyuiu.VarovaAA.Sprint7.Project.V12\bin\Release\InPutDataFile.csv";

            string row = "HUAWEI";
            int column = 1;
            string res = ds.CollectTextFromFile(path, row, column);


            string wait = "BoDe-WDH9";
            Assert.AreEqual(wait, res);
        }
    }
}

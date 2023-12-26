using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.BorisovaDS.Sprint7.Project.V4.Lib;

namespace Tyuiu.BorisovaDS.Sprint7.Project.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {

        DataService ds = new DataService();

        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.BorisovaDS.Sprint7\Tyuiu.BorisovaDS.Sprint7.Project.V4\OutPutFileProject.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}

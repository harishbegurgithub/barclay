using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void TestGetVersion()
        {
            string version = Program.GetVersion("c:/test.txt");
            Assert.IsNotNull(version);
        }

        [TestMethod()]
        public void TestGetSize()
        {
            int size = Program.GetSize("c:/test.txt");            
            Assert.IsNotNull(size); 
        }
    }
}
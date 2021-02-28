using Microsoft.VisualStudio.TestTools.UnitTesting;
using Video_Rental_2Assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_Rental_2Assignment.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            Form1 obj = new Form1();
            obj.testInsert("as", "12" ,"1234");

            Assert.IsTrue(true);
        }
    }
}
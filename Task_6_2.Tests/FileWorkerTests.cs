using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6_2.Tests
{
    [TestClass]
    public class FileWorkerTests
    {
        [TestMethod]
        public void GetSafeFilenameMustReturnString()
        {
            string expectedValue = "C__Users_user_Desktop";

            FileWorker worker = new FileWorker();
            PrivateObject obj = new PrivateObject(worker);
            string actualValue = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            Assert.AreEqual(expectedValue, obj.Invoke("GetSafeFilename", actualValue));
        }
    }
}

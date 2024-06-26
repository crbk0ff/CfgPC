using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp1;
using System.Windows.Forms;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Testopenform()
        {
            Form f = new Form();
            f.Show();
            Assert.IsTrue(f.Visible);
        }
        [TestMethod]
        public void Testotch()
        {
            main main = new main();
            main.otch();
        }

        [TestMethod]
        public void Testbutton()
        {
            main main = new main();
            main.prove();
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;

namespace nayapayV1
{
    [TestClass]
    public class UnitTest1
    {

        BaseClass bc1 = new BaseClass();
        Pagefunctions p1 = new Pagefunctions();


        #region Initializations and Cleanups




        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {

            // MessageBox.Show("Assembly Initialization");
            // AutoClosingMessageBox.Show("Assembly Initialization", "Caption", 1000);

        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            // MessageBox.Show("Assembly CleanUp");
            //AutoClosingMessageBox.Show("Assembly Cleanup", "Caption", 1000);

        }

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            // MessageBox.Show("Class Initialization");
            // AutoClosingMessageBox.Show("Class Initilization", "Caption", 1000);

        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            //MessageBox.Show("Class CleanUp");
            // AutoClosingMessageBox.Show("Class Cleanup", "Caption", 1000);

            //Baseclass.dr.Close();
            //Baseclass.dr.Quit();
            //Baseclass.dr.Dispose();
        }


        [TestInitialize]
        public void TestInit()
        {

            // MessageBox.Show("Test Initialization");
            // AutoClosingMessageBox.Show("Test initialization", "Caption", 1000);

            bc1.SelniumDriver();
            p1.Gotourl("https://dev.nayapay.com");

           
        }

        [TestCleanup]
        public void TestCleanup()
        {
            // MessageBox.Show("Test CleanUp");
            // AutoClosingMessageBox.Show("Test clean", "Caption", 1000);
            
        }

        #endregion



        [TestMethod]
        public void TestMethod1()
        {
            p1.Gototitle2("business");
            p1.Gototitle3("news");
            p1.Gototitle4("careers");
            p1.biggreenbtn();

        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Threading;

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
            p1.Gototitle2("Business");
            p1.Gototitle3("news");
            p1.Gototitle4("Careers");
            p1.biggreenbtn();
            Thread.Sleep(1000);
            p1.Reserve();
            Thread.Sleep(10000);
            p1.Ename("saad");
            Thread.Sleep(2000);
            p1.Etel("03452381341");
            Thread.Sleep(2000);
            p1.Eemail("saad@abc.com");
            Thread.Sleep(3000);
            p1.ChooseOS("iPhone");


        }

        [TestMethod]
        public void TestMethod2()
        {
            Thread.Sleep(2000);
            p1.Gototitle4("Careers");
            Thread.Sleep(3000);
            p1.Cwritterapply(p1.Randomname(5), p1.Randomemail(4), p1.Randomnumber(11), p1.Randomcnic(17), "Other", p1.Randomlinkedin(5));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Thread.Sleep(2000);
            p1.Gototitle4("Careers");
            Thread.Sleep(3000);
            p1.Devopsrapply(p1.Randomname(5), p1.Randomemail(4), p1.Randomnumber(11), p1.Randomcnic(17), "Other", p1.Randomlinkedin(5));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Thread.Sleep(2000);
            p1.Gototitle4("Careers");
            Thread.Sleep(3000);
            p1.Teamleadaply(p1.Randomname(5), p1.Randomemail(4), p1.Randomnumber(11), p1.Randomcnic(17), "Other", p1.Randomlinkedin(5));
        }



        [TestMethod]
        public void TestMethod5()
        {
            Thread.Sleep(2000);
            p1.Gototitle4("Careers");
            Thread.Sleep(3000);
            p1.Fraudmanagerapply(4, p1.Randomname(5), p1.Randomemail(4), p1.Randomnumber(11), p1.Randomcnic(17), "Other", p1.Randomlinkedin(5));

        }


        [TestMethod]
        public void TestMethod6()
        {
            Thread.Sleep(3000);
            p1.Marketingapply(5, p1.Randomname(5), p1.Randomemail(4), p1.Randomnumber(11), p1.Randomcnic(17), "Other", p1.Randomlinkedin(5));

        }

        [TestMethod]
        public void TestMethod7()
        {
            Thread.Sleep(3000);
            p1.Strategyapply(6 , p1.Randomname(5), p1.Randomemail(4), p1.Randomnumber(11), p1.Randomcnic(17), "Other", p1.Randomlinkedin(5));

        }


        [TestMethod]
        public void TestMethod8()
        {
            Thread.Sleep(3000);
            p1.Productapply(7, p1.Randomname(5), p1.Randomemail(4), p1.Randomnumber(11), p1.Randomcnic(17), "Other", p1.Randomlinkedin(5));

        }


        [TestMethod]
        public void TestMethod9()
        {
            Thread.Sleep(3000);
            p1.Brandapply(8, p1.Randomname(5), p1.Randomemail(4), p1.Randomnumber(11), p1.Randomcnic(17), "Other", p1.Randomlinkedin(5));

        }



        [TestMethod]
        public void TestMethod10()
        {
            p1.Gototitle3("News");
            p1.LinksforNews();

        }


    }
}

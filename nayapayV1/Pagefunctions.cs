using Amazon.DynamoDBv2;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nayapayV1
{
    class Pagefunctions : BaseClass
    {
       // By title2 = By.Id("w0-collapse");
        public void Gotourl(string url)
        {
            dr.Url = url;
            string exp_title = "NayaPay | Home";
            string act_title = dr.Title;

            Console.WriteLine("The site title is " + act_title);

            Assert.That(exp_title, Is.EqualTo(exp_title));
            Console.WriteLine("String Constraint Test Passed");

        }

        public void Gototitle2( string selectListOption)
        {
            
           /* var DivElement = dr.FindElement(By.Id("w0-collapse"));
            DivElement.FindElements(By.CssSelector(".navbar-right")).ElementAt(0).Click(); */

          /*  IList<IWebElement> selectElements = dr.FindElements(By.Id("w1"));
             selectElements.ElementAt(0).Click();*/

            dr.FindElement(By.CssSelector("ul#w1>li:nth-of-type(2)>a")).Click();

            /*var DivElement2 = dr.FindElement(By.ClassName("active"));
            var dropdown2 = new SelectElement(DivElement2);
            dropdown2.SelectByText("business");*/

            //By title2 = By.Id("w1");

            //// IWebElement selectElement = dr.FindElement(By.CssSelector("w1"));
            ////Select selectInstance = Select(selectElement);
            //var t2=dr.FindElement(title2);
            ////var drilldown = new SelectElement(t2);
            ////drilldown.SelectByIndex(1);

            //SelectElement ss = new SelectElement(t2);


            //foreach (IWebElement element in ss.Options)
            //{
            //    if (element.Text == selectListOption)
            //    {
            //        element.Click();
            //    }
            //}
            ////var select_title2 = new SelectElement(st2);

            ////select_title2.Options.ToList().Find(x=> x.Text==selectListOption).Click();


            string exp_title = "NayaPay | " + selectListOption;
            string act_title = dr.Title;

            Console.WriteLine("The site title is " + act_title);

            Assert.That(exp_title, Is.EqualTo(exp_title));
            Console.WriteLine("String Constraint Test Passed");


        }


        public void Gototitle3(string selectListOption)
        {
            By title2 = By.XPath("/html/body/div/nav/div/div[2]/ul/li[3]/a");
            
            dr.FindElement(title2).Click();

            string exp_title = "NayaPay | " + selectListOption;

            string act_title = dr.Title;

            Console.WriteLine("The site title is " + act_title);

            Assert.That(exp_title, Is.EqualTo(exp_title));
            Console.WriteLine("String Constraint Test Passed");
        }

        public void Gototitle4(string selectListOption)
        {
            By title2 = By.XPath("/html/body/div/nav/div/div[2]/ul/li[4]/a");

            dr.FindElement(title2).Click();


            string exp_title = "NayaPay | "+ selectListOption ;
            string act_title = dr.Title;

            Console.WriteLine("The site title is " + act_title);

            Assert.That(exp_title, Is.EqualTo(exp_title));
            Console.WriteLine("String Constraint Test Passed");
        }



        public void biggreenbtn()
        {
            By title2 = By.XPath("/html/body/div/nav/div/div[2]/ul/li[5]/a");

            dr.FindElement(title2).Click();


            string exp_title = "NayaPay | Waitlist";
            string act_title = dr.Title;

            Console.WriteLine("The site title is " + act_title);

            Assert.That(exp_title, Is.EqualTo(exp_title));
            Console.WriteLine("String Constraint Test Passed");
        }



    }


}

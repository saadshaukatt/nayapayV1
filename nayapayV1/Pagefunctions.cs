using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

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

        public void Gototitle2(string selectListOption)
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
            dr.FindElement(By.CssSelector("ul#w1>li:nth-of-type(3)>a")).Click();
            /*By title2 = By.XPath("/html/body/div/nav/div/div[2]/ul/li[3]/a");
            
            dr.FindElement(title2).Click();*/

            string exp_title = "NayaPay | " + selectListOption;

            string act_title = dr.Title;

            Console.WriteLine("The site title is " + act_title);

            Assert.That(exp_title, Is.EqualTo(exp_title));
            Console.WriteLine("String Constraint Test Passed");
        }

        public void Gototitle4(string selectListOption)
        {
            /*By title2 = By.XPath("/html/body/div/nav/div/div[2]/ul/li[4]/a");

            dr.FindElement(title2).Click();*/
            dr.FindElement(By.CssSelector("ul#w1>li:nth-of-type(4)>a")).Click();


            string exp_title = "NayaPay | " + selectListOption;
            string act_title = dr.Title;

            Console.WriteLine("The site title is " + act_title);

            Assert.That(exp_title, Is.EqualTo(exp_title));
            Console.WriteLine("String Constraint Test Passed");
        }



        public void biggreenbtn()
        {
            /* By title2 = By.XPath("/html/body/div/nav/div/div[2]/ul/li[5]/a");

             dr.FindElement(title2).Click();*/
            dr.FindElement(By.CssSelector("ul#w1>li:nth-of-type(5)>a")).Click();

            string exp_title = "NayaPay | Waitlist";
            string act_title = dr.Title;

            Console.WriteLine("The site title is " + act_title);

            Assert.That(exp_title, Is.EqualTo(exp_title));
            Console.WriteLine("String Constraint Test Passed");
        }


        public void Reserve()
        {

            dr.FindElement(By.CssSelector("html>body>div>div>div:nth-of-type(2)>div>div>div>div>div>div:nth-of-type(2)>a")).Click();

        }



        public void Etel(string tell)
        {
            By tel = By.Name("tel");
            dr.FindElement(tel).SendKeys(tell);
            dr.FindElement(tel).SendKeys(Keys.Enter);

            //dr.FindElement(By.CssSelector("div#stkv-form-root>div:nth-of-type(2)>div>div:nth-of-type(2)>section>div>div>div>div>div>div>div>fieldset>div:nth-of-type(2)>div:nth-of-type(2)>div>div>div:nth-of-type(2)>div>div>button")).Click();
            //dr.FindElement(By.ClassName("button__ButtonWrapper-sc-1g3rldj-0.bYbkR")).Click();
        }


        public void Ename(string name)
        {
            // can enter numbers as well FIX
            //dr.FindElement(By.Id("nayaPayWaitlist")).Click();


            //dr.SwitchTo().Frame(dr.FindElement(By.TagName("iframe")));
            dr.SwitchTo().Frame(0);
            dr.FindElement(By.ClassName("input__InputField-p8yw0p-0")).SendKeys(name);
            dr.FindElement(By.ClassName("input__InputField-p8yw0p-0")).SendKeys(Keys.Enter);

            //dr.FindElement(By.XPath("/html/body/div[3]/main/div[1]/div[2]/div/div/div[3]/div/div[1]/section/div/div/div/div/div/div/div/div/div[2]/div/div/div/div[2]/div/div/button")).Click();

           // dr.FindElement(By.XPath("/html/body/div[3]/main/div[1]/div[2]/div/div/div[2]/div/div[1]/section/div/div/div/div/div/div/div/div/div[2]/input")).SendKeys(name);
            //dr.FindElement(By.CssSelector("div#stkv-form-root>div:nth-of-type(2)>div>div>section>div>div>div>div>div>div>div>div>div:nth-of-type(2)>div>div>div>div:nth-of-type(2)>div>div>button")).Click();

            //dr.FindElement(By.XPath("//*[@id=short_text - 01F0RXSX78SEW35PEXNWP46P5T - dpvHdnnDMJN9Et3m]")).SendKeys(name);

            //dr.FindElement(By.XPath("/html/body/div[3]/main/div[1]/div[2]/div/div/div[2]/div/div[1]/section/div/div/div/div/div/div/div/div/div[2]/input")).SendKeys(name);



            //dr.FindElement(By.ClassName("input__InputField-p8yw0p-0")).SendKeys(name);
            //dr.FindElement(By.CssSelector("div#stkv-form-root>div:nth-of-type(2)>div>div>section>div>div>div>div>div>div>div>div>div:nth-of-type(2)>input")).SendKeys(name);

            /*dr.FindElement(By.XPath("(//input[@class='input__InputField-p8yw0p-0 hbbBVn'])[1]")).SendKeys(name);
            dr.FindElement(By.XPath("(//button[@class='button__ButtonWrapper-sc-1g3rldj-0 bYbkR'])[1]")).Click();*/
        }


        public void Eemail(string email)
        {
            dr.FindElement(By.Name("email")).SendKeys(email);
            dr.FindElement(By.Name("email")).SendKeys(Keys.Enter);

           // dr.FindElement(By.CssSelector("div#stkv-form-root>div:nth-of-type(2)>div>div:nth-of-type(3)>section>div>div>div>div>div>div>div>div>div:nth-of-type(2)>div>div>div>div:nth-of-type(2)>div>div>button")).Click();
        }



        public void ChooseOS(string choose)
        {
            //dr.FindElement(By.XPath("//li[contains(@class,'base-choice__Root-sc-5koeqf-0 hyJvoY')]")).Click();
            dr.FindElement(By.XPath("//div[text()='"+choose+"']")).Click();
            dr.FindElement(By.XPath("/html/body/div[3]/main/div[1]/div[2]/div/div/div[3]/div/div[4]/section/div/div/div/div/div/div/div/fieldset/div[2]/div/div[2]/div/div/div[1]/div/div[1]/div/div/button")).Click();

            /* dr.FindElement(By.ClassName("checkbox-choice__ChoiceContent-m4g23g-1.erBFfO")).Click();
             dr.FindElement(By.ClassName("checkbox-choice__ChoiceContent-m4g23g-1.erBFfO")).Click();*/
            //dr.FindElement(By.CssSelector("div#stkv-form-root>div:nth-of-type(2)>div>div:nth-of-type(4)>section>div>div>div>div>div>div>div>fieldset>div:nth-of-type(2)>div>div:nth-of-type(2)>div>div>div>div>div>div>div>button")).Click();

            string exp_title = "NayaPay | Waitlist";

            string act_title = dr.Title;

            Console.WriteLine("The site title is " + act_title);

            Assert.That(exp_title, Is.EqualTo(exp_title));
            Console.WriteLine("String Constraint Test Passed");

        }

        public void Cwritterapply(string fname, string email, string cnum, string cnic, string hearabt, string lprofile)
        {
            dr.FindElement(By.ClassName("view-modal")).Click();
           // _= dr.Manage().Timeouts().ImplicitWait;
            Thread.Sleep(2000);
            dr.SwitchTo().ActiveElement().FindElement(By.ClassName("popup-apply")).Click();
            Thread.Sleep(5000);
            dr.SwitchTo().Frame(0);
            //dr.FindElement(By.CssSelector("input#ContentPlaceHolder1_txtEmail")).SendKeys(fname);
            //dr.FindElement(By.Name("ctl00$ContentPlaceHolder1$txtEmail")).SendKeys(fname);
            dr.FindElement(By.Id("ContentPlaceHolder1_txtFullName")).SendKeys(fname);
            dr.FindElement(By.Id("ContentPlaceHolder1_txtEmail")).SendKeys(email);
            dr.FindElement(By.Id("ContentPlaceHolder1_txtCellNo")).SendKeys(cnum);
            dr.FindElement(By.Id("ContentPlaceHolder1_txtCNIC")).SendKeys(cnic);

           

            var select1 = dr.FindElement(By.Id("ContentPlaceHolder1_ddlHowHeardAboutUs"));
            var dropdown1 = new SelectElement(select1);
            dropdown1.SelectByText(hearabt);

            dr.FindElement(By.Id("ContentPlaceHolder1_txtLinkedInUrl")).SendKeys(lprofile);
            
            IWebElement upload = dr.FindElement(By.XPath("(//input[@class='form-control fileinput-controls'])[1]"));
            ((RemoteWebElement)upload).SendKeys(@"C:\try1.docx");
            //dr.FindElement(By.ClassName("fileinput-controls"));
            //driver.findElement(By.xpath("(//input[@class='form-control fileinput-controls'])[1]")).getAttribute("attribute_value");
            //upload.Click();
            //upload.SendKeys(@"‪C:\try1.doc");



        }

    }


  

}

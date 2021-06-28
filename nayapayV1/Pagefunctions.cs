using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;
using System.Threading;

namespace nayapayV1
{
    class Pagefunctions : BaseClass
    {
        // By title2 = By.Id("w0-collapse");
        #region functions/strings
        string exp_h2 = "Your application has been submitted successfully.";
        string exp_acc = "You have already applied for this job.";

        By txtname=By.Id("ContentPlaceHolder1_txtFullName");
        By txtemail=By.Id("ContentPlaceHolder1_txtEmail");
        By cellno=By.Id("ContentPlaceHolder1_txtCellNo");
        By bcnic= By.Id("ContentPlaceHolder1_txtCNIC");










        public  string Randomname(int length)
        {

            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string a= new string(Enumerable.Repeat( chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
            return "test" + a;
        }       
        public  string Randomemail(int length)
        {

            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string a= new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
            return a + "@" + a + ".com";
        }

        public  string Randomnumber(int length)
        {

            Random random = new Random();
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public  string Randomcnic(int length)
        {

            Random random = new Random();
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars , length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public string Randomlinkedin(int length)
        {

            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string a= new string(Enumerable.Repeat(chars , length).Select(s => s[random.Next(s.Length)]).ToArray());
            return a+"linkedin";
        }

        #endregion

        public void Gotourl(string url)
        {
            dr.Url = url;
            string exp_title = "NayaPay | Home";
            string act_title = dr.Title;


            Console.WriteLine("The site title is " + act_title);
            Assert.That(act_title, Is.EqualTo(exp_title));


            Console.WriteLine("String Constraint Test Passed");

        }

        public void Uploadfile(string cv, string letter)
        {
            IWebElement upload = dr.FindElement(By.ClassName("fileinput-controls"));// dr.FindElement(By.XPath("(//input[@class='form-control fileinput-controls'])[1]"));
            ((RemoteWebElement)upload).SendKeys(cv);
            IWebElement upload2 = dr.FindElement(By.Id("ContentPlaceHolder1_flCoverLetter"));
            ((RemoteWebElement)upload2).SendKeys(letter);
            Thread.Sleep(3000);
            dr.FindElement(By.Id("ContentPlaceHolder1_btnapply")).Click();

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

            Assert.That(act_title, Is.EqualTo(exp_title));
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

        public void Gototitle4(string selectListOption)//CAREERS111
        {
            /*By title2 = By.XPath("/html/body/div/nav/div/div[2]/ul/li[4]/a");

            dr.FindElement(title2).Click();*/
            dr.FindElement(By.CssSelector("ul#w1>li:nth-of-type(4)>a")).Click();


            string exp_title = "NayaPay | " + selectListOption;
            string act_title = dr.Title;

            Console.WriteLine("The site title is " + act_title);

            Assert.That(act_title, Is.EqualTo(exp_title));
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
            dr.FindElement(By.XPath("//div[text()='" + choose + "']")).Click();
            dr.FindElement(By.XPath("/html/body/div[3]/main/div[1]/div[2]/div/div/div[3]/div/div[4]/section/div/div/div/div/div/div/div/fieldset/div[2]/div/div[2]/div/div/div[1]/div/div[1]/div/div/button")).Click();

            /* dr.FindElement(By.ClassName("checkbox-choice__ChoiceContent-m4g23g-1.erBFfO")).Click();
             dr.FindElement(By.ClassName("checkbox-choice__ChoiceContent-m4g23g-1.erBFfO")).Click();*/
            //dr.FindElement(By.CssSelector("div#stkv-form-root>div:nth-of-type(2)>div>div:nth-of-type(4)>section>div>div>div>div>div>div>div>fieldset>div:nth-of-type(2)>div>div:nth-of-type(2)>div>div>div>div>div>div>div>button")).Click();

            string exp_title = "NayaPay | Waitlist";

            string act_title = dr.Title;

            Console.WriteLine("The site title is " + act_title);

            Assert.That(act_title, Is.EqualTo(exp_title));
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
            dr.FindElement(txtname).SendKeys(fname);
            dr.FindElement(txtemail).SendKeys(email);
            dr.FindElement(cellno).SendKeys(cnum);
            dr.FindElement(bcnic).SendKeys(cnic);



            var select1 = dr.FindElement(By.Id("ContentPlaceHolder1_ddlHowHeardAboutUs"));
            var dropdown1 = new SelectElement(select1);
            dropdown1.SelectByText(hearabt);

            dr.FindElement(By.Id("ContentPlaceHolder1_txtLinkedInUrl")).SendKeys(lprofile);



            Uploadfile("C:\\NOOQI - Share Meal Plan to folks (ver 1.0).pdf", "C:\\try1.docx");

            /*IWebElement upload = dr.FindElement(By.ClassName("fileinput-controls"));// dr.FindElement(By.XPath("(//input[@class='form-control fileinput-controls'])[1]"));
            ((RemoteWebElement)upload).SendKeys(@"C:\try1.docx");
            //dr.FindElement(By.ClassName("fileinput-controls"));
            //driver.findElement(By.xpath("(//input[@class='form-control fileinput-controls'])[1]")).getAttribute("attribute_value");
            //upload.Click();
            //upload.SendKeys(@"‪C:\try1.doc");
            IWebElement upload2 = dr.FindElement(By.Id("ContentPlaceHolder1_flCoverLetter"));
            ((RemoteWebElement)upload2).SendKeys(@"C:\try1.docx");
            Thread.Sleep(3000);
            dr.FindElement(By.Id("ContentPlaceHolder1_btnapply")).Click();*/

            string act_title = dr.FindElement(By.CssSelector("html>body>div:nth-of-type(3)>p")).Text;
            Assert.That(act_title, (Is.EqualTo(exp_h2) | (Is.EqualTo(exp_acc))));


        }

        public void Devopsrapply(string fname, string email, string cnum, string cnic, string hearabt, string lprofile)
        {
            dr.FindElement(By.XPath("(//button[contains(@class,'btn clear')])[2]")).Click();//dr.FindElement(By.ClassName("view-modal")).Click();
            // _= dr.Manage().Timeouts().ImplicitWait;
            Thread.Sleep(2000);
            dr.SwitchTo().ActiveElement().FindElement(By.ClassName("popup-apply")).Click();
            Thread.Sleep(5000);
            dr.SwitchTo().Frame(0);
            //dr.FindElement(By.CssSelector("input#ContentPlaceHolder1_txtEmail")).SendKeys(fname);
            //dr.FindElement(By.Name("ctl00$ContentPlaceHolder1$txtEmail")).SendKeys(fname);
            dr.FindElement(txtname).SendKeys(fname);
            dr.FindElement(txtemail).SendKeys(email);
            dr.FindElement(cellno).SendKeys(cnum);
            dr.FindElement(bcnic).SendKeys(cnic);



            var select1 = dr.FindElement(By.Id("ContentPlaceHolder1_ddlHowHeardAboutUs"));
            var dropdown1 = new SelectElement(select1);
            dropdown1.SelectByText(hearabt);

            dr.FindElement(By.Id("ContentPlaceHolder1_txtLinkedInUrl")).SendKeys(lprofile);

            Uploadfile("C:\\NOOQI - Share Meal Plan to folks (ver 1.0).pdf", "C:\\try1.docx");
            /*IWebElement upload = dr.FindElement(By.ClassName("fileinput-controls"));// dr.FindElement(By.XPath("(//input[@class='form-control fileinput-controls'])[1]"));
            ((RemoteWebElement)upload).SendKeys(@"C:\try1.docx");
            IWebElement upload2 = dr.FindElement(By.Id("ContentPlaceHolder1_flCoverLetter"));
            ((RemoteWebElement)upload2).SendKeys(@"C:\try1.docx");
            Thread.Sleep(3000);
            dr.FindElement(By.Id("ContentPlaceHolder1_btnapply")).Click();*/

            string act_title = dr.FindElement(By.CssSelector("html>body>div:nth-of-type(3)>p")).Text;
            Assert.That(act_title, (Is.EqualTo(exp_h2) | (Is.EqualTo(exp_acc))));



        }

        public void Teamleadaply(string fname, string email, string cnum, string cnic, string hearabt, string lprofile)
        {
            dr.FindElement(By.XPath("(//button[contains(@class,'btn clear')])[3]")).Click();
            Thread.Sleep(2000);
            dr.SwitchTo().ActiveElement().FindElement(By.ClassName("popup-apply")).Click();
            Thread.Sleep(5000);
            dr.SwitchTo().Frame(0);
            //dr.FindElement(By.CssSelector("input#ContentPlaceHolder1_txtEmail")).SendKeys(fname);
            //dr.FindElement(By.Name("ctl00$ContentPlaceHolder1$txtEmail")).SendKeys(fname);
            dr.FindElement(txtname).SendKeys(fname);
            dr.FindElement(txtemail).SendKeys(email);
            dr.FindElement(cellno).SendKeys(cnum);
            dr.FindElement(bcnic).SendKeys(cnic);

            var select1 = dr.FindElement(By.Id("ContentPlaceHolder1_ddlHowHeardAboutUs"));
            var dropdown1 = new SelectElement(select1);
            dropdown1.SelectByText(hearabt);

            dr.FindElement(By.Id("ContentPlaceHolder1_txtLinkedInUrl")).SendKeys(lprofile);

            Uploadfile("C:\\NOOQI - Share Meal Plan to folks (ver 1.0).pdf", "C:\\try1.docx");

            /*IWebElement upload = dr.FindElement(By.ClassName("fileinput-controls"));// dr.FindElement(By.XPath("(//input[@class='form-control fileinput-controls'])[1]"));
            ((RemoteWebElement)upload).SendKeys(@"C:\NOOQI - Share Meal Plan to folks (ver 1.0).pdf");
            IWebElement upload2 = dr.FindElement(By.Id("ContentPlaceHolder1_flCoverLetter"));
            ((RemoteWebElement)upload2).SendKeys(@"C:\try1.docx");*/

            Thread.Sleep(5000);
            // dr.FindElement(By.Id("ContentPlaceHolder1_btnapply")).Click();
            //dr.FindElement(By.Name("ctl00$ContentPlaceHolder1$btnapply")).Click();

            string act_title = dr.FindElement(By.CssSelector("html>body>div:nth-of-type(3)>p")).Text;
            Console.WriteLine("The Header is " + act_title);
            Assert.That(act_title, (Is.EqualTo(exp_h2) | (Is.EqualTo(exp_acc))));

            /*  if (act_title == exp_h2)
              {
                  Assert.That(act_title, (Is.EqualTo(exp_h2)));
              }
              else
              {
                  Assert.That(act_title, (Is.EqualTo(exp_acc)));

              }*/

            Console.WriteLine("String Constraint Test Passed");

        }



        public void Fraudmanagerapply(int num, string fname, string email, string cnum, string cnic, string hearabt, string lprofile)
        {
            dr.FindElement(By.XPath("(//button[contains(@class,'btn clear')])[" + num + " ]")).Click();
            // _= dr.Manage().Timeouts().ImplicitWait;
            Thread.Sleep(2000);
            dr.SwitchTo().ActiveElement().FindElement(By.ClassName("popup-apply")).Click();
            Thread.Sleep(5000);
            dr.SwitchTo().Frame(0);
            //dr.FindElement(By.CssSelector("input#ContentPlaceHolder1_txtEmail")).SendKeys(fname);
            //dr.FindElement(By.Name("ctl00$ContentPlaceHolder1$txtEmail")).SendKeys(fname);
            dr.FindElement(txtname).SendKeys(fname);
            dr.FindElement(txtemail).SendKeys(email);
            dr.FindElement(cellno).SendKeys(cnum);
            dr.FindElement(bcnic).SendKeys(cnic);



            var select1 = dr.FindElement(By.Id("ContentPlaceHolder1_ddlHowHeardAboutUs"));
            var dropdown1 = new SelectElement(select1);
            dropdown1.SelectByText(hearabt);

            dr.FindElement(By.Id("ContentPlaceHolder1_txtLinkedInUrl")).SendKeys(lprofile);
            Uploadfile("C:\\NOOQI - Share Meal Plan to folks (ver 1.0).pdf", "C:\\try1.docx");


            /* IWebElement upload = dr.FindElement(By.ClassName("fileinput-controls"));// dr.FindElement(By.XPath("(//input[@class='form-control fileinput-controls'])[1]"));
             ((RemoteWebElement)upload).SendKeys("C:\\NOOQI - Share Meal Plan to folks (ver 1.0).pdf");
             IWebElement upload2 = dr.FindElement(By.Id("ContentPlaceHolder1_flCoverLetter"));
             ((RemoteWebElement)upload2).SendKeys(@"C:\try1.docx");*/



            //dr.SwitchTo().Frame(1);
            //dr.SwitchTo().Alert();
            string act_title = dr.FindElement(By.CssSelector("html>body>div:nth-of-type(3)>p")).Text;

            Assert.That(act_title, (Is.EqualTo(exp_h2) | (Is.EqualTo(exp_acc))));

            Console.WriteLine("The Header is " + act_title);
            //string expected_titles = { "You have already applied for this job.", exp_h2 };

            Console.WriteLine("String Constraint Test Passed");


        }

        public void Marketingapply(int num, string fname, string email, string cnum, string cnic, string hearabt, string lprofile)
        {
            Gototitle4("Careers");


            dr.FindElement(By.XPath("(//button[contains(@class,'btn clear')])[" + num + " ]")).Click();
            Thread.Sleep(2000);
            dr.SwitchTo().ActiveElement().FindElement(By.ClassName("popup-apply")).Click();
            Thread.Sleep(5000);
            dr.SwitchTo().Frame(0);
            dr.FindElement(txtname).SendKeys(fname);
            dr.FindElement(txtemail).SendKeys(email);
            dr.FindElement(cellno).SendKeys(cnum);
            dr.FindElement(bcnic).SendKeys(cnic);

            var select1 = dr.FindElement(By.Id("ContentPlaceHolder1_ddlHowHeardAboutUs"));
            var dropdown1 = new SelectElement(select1);
            dropdown1.SelectByText(hearabt);

            dr.FindElement(By.Id("ContentPlaceHolder1_txtLinkedInUrl")).SendKeys(lprofile);

            Uploadfile("C:\\NOOQI - Share Meal Plan to folks (ver 1.0).pdf", "C:\\try1.docx");

            string act_title = dr.FindElement(By.CssSelector("html>body>div:nth-of-type(3)>p")).Text;
            Console.WriteLine("The Header is " + act_title);
            Assert.That(act_title, (Is.EqualTo(exp_h2)));
            Console.WriteLine("String Constraint Test Passed");

            Marketingapply2(num, fname, email, cnum, cnic, hearabt, lprofile);


        }


        public void Marketingapply2(int num, string fname, string email, string cnum, string cnic, string hearabt, string lprofile)
        {
            SelniumDriver();
            Gotourl("https://dev.nayapay.com");
            Gototitle4("Careers");


            dr.FindElement(By.XPath("(//button[contains(@class,'btn clear')])[" + num + " ]")).Click();
            Thread.Sleep(2000);
            dr.SwitchTo().ActiveElement().FindElement(By.ClassName("popup-apply")).Click();
            Thread.Sleep(5000);
            dr.SwitchTo().Frame(0);
            dr.FindElement(txtname).SendKeys(fname);
            dr.FindElement(txtemail).SendKeys(email);
            dr.FindElement(cellno).SendKeys(cnum);
            dr.FindElement(bcnic).SendKeys(cnic);

            var select1 = dr.FindElement(By.Id("ContentPlaceHolder1_ddlHowHeardAboutUs"));
            var dropdown1 = new SelectElement(select1);
            dropdown1.SelectByText(hearabt);

            dr.FindElement(By.Id("ContentPlaceHolder1_txtLinkedInUrl")).SendKeys(lprofile);

            Uploadfile("C:\\NOOQI - Share Meal Plan to folks (ver 1.0).pdf", "C:\\try1.docx");

            string act_title = dr.FindElement(By.CssSelector("html>body>div:nth-of-type(3)>p")).Text;
            Console.WriteLine("The Header is " + act_title);
            Assert.That(act_title, (Is.EqualTo(exp_acc)));
            Console.WriteLine("String Constraint Test Passed");


        }


        public void Strategyapply(int num, string fname, string email, string cnum, string cnic, string hearabt, string lprofile)
        {
            Gototitle4("Careers");


            dr.FindElement(By.XPath("(//button[contains(@class,'btn clear')])[" + num + " ]")).Click();
            Thread.Sleep(2000);
            dr.SwitchTo().ActiveElement().FindElement(By.ClassName("popup-apply")).Click();
            Thread.Sleep(5000);
            dr.SwitchTo().Frame(0);
            dr.FindElement(txtname).SendKeys(fname);
            dr.FindElement(txtemail).SendKeys(email);
            dr.FindElement(cellno).SendKeys(cnum);
            dr.FindElement(bcnic).SendKeys(cnic);

            var select1 = dr.FindElement(By.Id("ContentPlaceHolder1_ddlHowHeardAboutUs"));
            var dropdown1 = new SelectElement(select1);
            dropdown1.SelectByText(hearabt);

            dr.FindElement(By.Id("ContentPlaceHolder1_txtLinkedInUrl")).SendKeys(lprofile);

            Uploadfile("C:\\NOOQI - Share Meal Plan to folks (ver 1.0).pdf", "C:\\try1.docx");

            string act_title = dr.FindElement(By.CssSelector("html>body>div:nth-of-type(3)>p")).Text;
            Console.WriteLine("The Header is " + act_title);
            Assert.That(act_title, (Is.EqualTo(exp_h2)));
            Console.WriteLine("String Constraint Test Passed");

            Strategyapply2(num, fname, email, cnum, cnic, hearabt, lprofile);


        }


        public void Strategyapply2(int num, string fname, string email, string cnum, string cnic, string hearabt, string lprofile)
        {
            SelniumDriver();
            Gotourl("https://dev.nayapay.com");
            Gototitle4("Careers");
           
            dr.FindElement(By.XPath("(//button[contains(@class,'btn clear')])[" + num + " ]")).Click();
            Thread.Sleep(2000);
            dr.SwitchTo().ActiveElement().FindElement(By.ClassName("popup-apply")).Click();
            Thread.Sleep(5000);
            dr.SwitchTo().Frame(0);
            dr.FindElement(txtname).SendKeys(fname);
            dr.FindElement(txtemail).SendKeys(email);
            dr.FindElement(cellno).SendKeys(cnum);
            dr.FindElement(bcnic).SendKeys(cnic);

            var select1 = dr.FindElement(By.Id("ContentPlaceHolder1_ddlHowHeardAboutUs"));
            var dropdown1 = new SelectElement(select1);
            dropdown1.SelectByText(hearabt);

            dr.FindElement(By.Id("ContentPlaceHolder1_txtLinkedInUrl")).SendKeys(lprofile);

            Uploadfile("C:\\NOOQI - Share Meal Plan to folks (ver 1.0).pdf", "C:\\try1.docx");

            string act_title = dr.FindElement(By.CssSelector("html>body>div:nth-of-type(3)>p")).Text;
            Console.WriteLine("The Header is " + act_title);
            Assert.That(act_title, (Is.EqualTo(exp_acc)));
            Console.WriteLine("String Constraint Test Passed");

        }


        public void Productapply(int num, string fname, string email, string cnum, string cnic, string hearabt, string lprofile)
        {
            Gototitle4("Careers");


            dr.FindElement(By.XPath("(//button[contains(@class,'btn clear')])[" + num + " ]")).Click();
            Thread.Sleep(2000);
            dr.SwitchTo().ActiveElement().FindElement(By.ClassName("popup-apply")).Click();
            Thread.Sleep(5000);
            dr.SwitchTo().Frame(0);
            dr.FindElement(txtname).SendKeys(fname);
            dr.FindElement(txtemail).SendKeys(email);
            dr.FindElement(cellno).SendKeys(cnum);
            dr.FindElement(bcnic).SendKeys(cnic);

            var select1 = dr.FindElement(By.Id("ContentPlaceHolder1_ddlHowHeardAboutUs"));
            var dropdown1 = new SelectElement(select1);
            dropdown1.SelectByText(hearabt);

            dr.FindElement(By.Id("ContentPlaceHolder1_txtLinkedInUrl")).SendKeys(lprofile);

            Uploadfile("C:\\NOOQI - Share Meal Plan to folks (ver 1.0).pdf", "C:\\try1.docx");

            string act_title = dr.FindElement(By.CssSelector("html>body>div:nth-of-type(3)>p")).Text;
            Console.WriteLine("The Header is " + act_title);
            Assert.That(act_title, (Is.EqualTo(exp_h2)));
            Console.WriteLine("String Constraint Test Passed");

            Productapply2(num, fname, email, cnum, cnic, hearabt, lprofile);


        }


        public void Productapply2(int num, string fname, string email, string cnum, string cnic, string hearabt, string lprofile)
        {
            SelniumDriver();
            Gotourl("https://dev.nayapay.com");
            Gototitle4("Careers");

            dr.FindElement(By.XPath("(//button[contains(@class,'btn clear')])[" + num + " ]")).Click();
            Thread.Sleep(2000);
            dr.SwitchTo().ActiveElement().FindElement(By.ClassName("popup-apply")).Click();
            Thread.Sleep(5000);
            dr.SwitchTo().Frame(0);
            dr.FindElement(txtname).SendKeys(fname);
            dr.FindElement(txtemail).SendKeys(email);
            dr.FindElement(cellno).SendKeys(cnum);
            dr.FindElement(bcnic).SendKeys(cnic);

            var select1 = dr.FindElement(By.Id("ContentPlaceHolder1_ddlHowHeardAboutUs"));
            var dropdown1 = new SelectElement(select1);
            dropdown1.SelectByText(hearabt);

            dr.FindElement(By.Id("ContentPlaceHolder1_txtLinkedInUrl")).SendKeys(lprofile);

            Uploadfile("C:\\NOOQI - Share Meal Plan to folks (ver 1.0).pdf", "C:\\try1.docx");

            string act_title = dr.FindElement(By.CssSelector("html>body>div:nth-of-type(3)>p")).Text;
            Console.WriteLine("The Header is " + act_title);
            Assert.That(act_title, (Is.EqualTo(exp_acc)));
            Console.WriteLine("String Constraint Test Passed");

        }


        public void Brandapply(int num, string fname, string email, string cnum, string cnic, string hearabt, string lprofile)
        {
            Gototitle4("Careers");


            dr.FindElement(By.XPath("(//button[contains(@class,'btn clear')])[" + num + " ]")).Click();
            Thread.Sleep(2000);
            dr.SwitchTo().ActiveElement().FindElement(By.ClassName("popup-apply")).Click();
            Thread.Sleep(5000);
            dr.SwitchTo().Frame(0);
            dr.FindElement(txtname).SendKeys(fname);
            dr.FindElement(txtemail).SendKeys(email);
            dr.FindElement(cellno).SendKeys(cnum);
            dr.FindElement(bcnic).SendKeys(cnic);

            var select1 = dr.FindElement(By.Id("ContentPlaceHolder1_ddlHowHeardAboutUs"));
            var dropdown1 = new SelectElement(select1);
            dropdown1.SelectByText(hearabt);

            dr.FindElement(By.Id("ContentPlaceHolder1_txtLinkedInUrl")).SendKeys(lprofile);

            Uploadfile("C:\\NOOQI - Share Meal Plan to folks (ver 1.0).pdf", "C:\\try1.docx");

            string act_title = dr.FindElement(By.CssSelector("html>body>div:nth-of-type(3)>p")).Text;
            Console.WriteLine("The Header is " + act_title);
            Assert.That(act_title, (Is.EqualTo(exp_h2)));
            Console.WriteLine("String Constraint Test Passed");

            Brandapply2(num, fname, email, cnum, cnic, hearabt, lprofile);


        }


        public void Brandapply2(int num, string fname, string email, string cnum, string cnic, string hearabt, string lprofile)
        {
            SelniumDriver();
            Gotourl("https://dev.nayapay.com");
            Gototitle4("Careers");

            dr.FindElement(By.XPath("(//button[contains(@class,'btn clear')])[" + num + " ]")).Click();
            Thread.Sleep(2000);
            dr.SwitchTo().ActiveElement().FindElement(By.ClassName("popup-apply")).Click();
            Thread.Sleep(5000);
            dr.SwitchTo().Frame(0);
            dr.FindElement(txtname).SendKeys(fname);
            dr.FindElement(txtemail).SendKeys(email);
            dr.FindElement(cellno).SendKeys(cnum);
            dr.FindElement(bcnic).SendKeys(cnic);

            var select1 = dr.FindElement(By.Id("ContentPlaceHolder1_ddlHowHeardAboutUs"));
            var dropdown1 = new SelectElement(select1);
            dropdown1.SelectByText(hearabt);

            dr.FindElement(By.Id("ContentPlaceHolder1_txtLinkedInUrl")).SendKeys(lprofile);

            Uploadfile("C:\\NOOQI - Share Meal Plan to folks (ver 1.0).pdf", "C:\\try1.docx");

            string act_title = dr.FindElement(By.CssSelector("html>body>div:nth-of-type(3)>p")).Text;
            Console.WriteLine("The Header is " + act_title);
            Assert.That(act_title, (Is.EqualTo(exp_acc)));
            Console.WriteLine("String Constraint Test Passed");
                       
        }




        public void LinksforNews()
        {

            dr.FindElement(By.CssSelector("html>body>div>div>div:nth-of-type(2)>div>section>div>div:nth-of-type(2)>a")).Click();

            String linkacc1 = dr.FindElement(By.ClassName("title")).Text;
            string linkexp1 = "Jazz and NayaPay team up for digitization of payments";
            Assert.That(linkacc1, Is.EqualTo(linkexp1));

            dr.Navigate().Back();


        }



    }




}

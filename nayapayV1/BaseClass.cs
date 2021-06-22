using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nayapayV1
{
    public  class BaseClass
    {
       public static IWebDriver dr ;
       


        public void SelniumDriver()
        {
            var driver = new ChromeDriver();
            dr = driver;
        }
    }
}

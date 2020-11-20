using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Threading;

namespace WhiteStarLoginUnitTestTC0002
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            AppiumOptions appOptions = new AppiumOptions();
            appOptions.AddAdditionalCapability("app", @"C:\Users\User01\source\repos\LoginaWHLoad\LoginaWHLoad\bin\Debug\LoginaWHLoad.exe");

            WindowsDriver<WindowsElement> Driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), appOptions);

            Assert.AreEqual("White Star Login Form", Driver.Title);
            Console.WriteLine(Driver.Title);
            Thread.Sleep(2000);
            Driver.FindElementByAccessibilityId("txtb_User").SendKeys("Vinicius Miranda de Pinho");
            Thread.Sleep(1000);
            Driver.FindElementByAccessibilityId("txtb_Password").SendKeys("12345678");
            Thread.Sleep(1000);
            Driver.FindElementByName("LOGIN").Click();
            Thread.Sleep(500);
            var message = Driver.FindElementByAccessibilityId("lbl_loginsucess").Text;
            Console.WriteLine(message);
            Assert.AreEqual("Congratulations Sucess! ", message);
            Console.WriteLine("Compare message login");
            Thread.Sleep(3000);
            Driver.FindElementByName("EXIT").Click();
            

        }   
    }
}

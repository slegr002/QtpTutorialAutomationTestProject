using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Drawing;
using System.Threading;

namespace QtpTutorialAutomationTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Create an object of type IWebDriver for the Chrome browser
            IWebDriver driver = new ChromeDriver(@"C:\Users\slegros\Documents");

            //Launch the www.qtptutorial.net site
            driver.Navigate().GoToUrl("https://www.ultimateqa.com/");
            //Maximize the size of the Chrome Browser
            driver.Manage().Window.Size = new Size(1024, 768);

            //Wait until the Element is displayed
            Thread.Sleep(500);


            //Click on the Automation Resource button
            driver.FindElement(By.XPath("//A[@href='https://www.ultimateqa.com/video-tutorials/']" +
                "[text()='Video Tutorials'][text()='Video Tutorials']/self::A")).Click();

            //Wait until the element is displayed
            Thread.Sleep(500);

            //In https://Courses.ultimateqa.com click on page 2
            driver.FindElement(By.XPath("//A[@href='/?page=2'][text()='2']/self::A")).Click();

            //Wait until the element is displayed
            Thread.Sleep(500);

            //Now Click on Page 1 to go back
            driver.FindElement(By.XPath("//A[@href='/?page=1'][text()='1']/self::A")).Click();

            //Wait until the element is displayed
            Thread.Sleep(500);

            //Go back to the Home Page
            driver.FindElement(By.XPath("//" +
                "IMG[@src='https://s3.amazonaws.com/thinkific/site_themes/logo_000/003/880/1459001419.medium.png?1459001419']" +
                "/self::IMG")).Click();

            //Wait until the element is displayed
            Thread.Sleep(500);

            //Go to "Selenium WebDriver Resources" link on the home page
            driver.FindElement(By.XPath("//A[@href='https://www.ultimateqa.com/best-selenium-webdriver-resources/']" +
                "[text()='Selenium WebDriver Resources'][text()='Selenium WebDriver Resources']/self::A")).Click();


            //Wait until the element is displayed
            Thread.Sleep(500);

            //Scroll down the "Selenium WebDriver Resources" page
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");

            //Wait until the element is displayed
            Thread.Sleep(500);

            //Scroll up the "Selenium WebDriver Resources" page
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, 0)");


            //Wait until the element is displayed
            Thread.Sleep(500);

            //Go back to the Home page
            driver.FindElement(By.XPath("//IMG[@id='logo']/self::IMG")).Click();

            //Wait until the element is displayed
            Thread.Sleep(500);

            //Click on "Automation Excercises" on the Homepage
            driver.FindElement(By.XPath("//A[@href='https://www.ultimateqa.com/automation/']" +
                "[text()='Automation Exercises'][text()='Automation Exercises']/self::A")).Click();

            //Wait until the element is displayed
            Thread.Sleep(500);

            //Click on "Login Automation" exercise
            driver.FindElement(By.XPath("//A[@href='https://courses.ultimateqa.com/users/sign_in']" +
                "[text()='Login automation']/self::A")).Click();

            //Steps To Create an Account 

            //Wait until the element is displayed
            //Thread.Sleep(500);

            //Click on the "Create a new account" link
           // driver.FindElement(By.LinkText("Create a new account")).Click();

            //Wait until the element is displayed
            //Thread.Sleep(500);

            //Delete any value present in the Firstname field and enter a new value
            //driver.FindElement(By.XPath("//INPUT[@id='user_first_name']/self::INPUT")).Clear();
            //driver.FindElement(By.XPath("//INPUT[@id='user_first_name']/self::INPUT")).SendKeys("TestFirstName");

            //Wait until the element is displayed
            //Thread.Sleep(500);

            //Delete any value present in the Lastname field and enter a new value
            //driver.FindElement(By.XPath("//INPUT[@id='user_last_name']/self::INPUT")).Clear();
            //driver.FindElement(By.XPath("//INPUT[@id='user_last_name']/self::INPUT")).SendKeys("TestLastName");

            //Wait until the element is displayed
            //Thread.Sleep(500);

            //Delete any value present in the Email field and enter a new value
            //driver.FindElement(By.XPath("//INPUT[@id='user_email']/self::INPUT")).Clear();
            //driver.FindElement(By.XPath("//INPUT[@id='user_email']/self::INPUT")).SendKeys("TestEmail@SeleniumTest.com");

            //Wait until the element is displayed
            //Thread.Sleep(500);

            //Delete any value present in the New password field and enter a new value
            //driver.FindElement(By.XPath("//INPUT[@id='user_password']/self::INPUT")).Clear();
            //driver.FindElement(By.XPath("//INPUT[@id='user_password']/self::INPUT")).SendKeys("TestPassword1");

            //Click on the Sign Up button
            //driver.FindElement(By.XPath("//INPUT[@id='btn-signup']/self::INPUT")).Click();

            //Wait until the element is displayed
            Thread.Sleep(500);

            //Enter the Email address to login
            driver.FindElement(By.XPath("//INPUT[@id='user_email']/self::INPUT")).Clear();
            driver.FindElement(By.XPath("//INPUT[@id='user_email']/self::INPUT")).SendKeys("TestEmail@SeleniumTest.com");

            // //Wait until the element is displayed
            Thread.Sleep(500);

            //Enter the Password to sign in
            driver.FindElement(By.XPath("//INPUT[@id='user_password']/self::INPUT")).Clear();
            driver.FindElement(By.XPath("//INPUT[@id='user_password']/self::INPUT")).SendKeys("TestPassword1");

            //Wait until the element is displayed
            Thread.Sleep(500);

            //Click on the Sign In button
            driver.FindElement(By.XPath("//INPUT[@id='btn-signin']/self::INPUT")).Click();




            driver.Dispose();

        }
    }
}

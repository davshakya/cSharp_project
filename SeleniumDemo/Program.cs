using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumDemo
{
    internal class Program
    {
        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        [SetUp]
        public void Initialize()
        {
            Console.WriteLine("Initialize Browser");
            driver.Navigate().GoToUrl("https://www.google.com");

        }

        [Test]
        public void ExecuteTC()
        {
            IWebElement element = driver.FindElement(By.Name("q"));
            element.SendKeys("Hello C#");
        }

        [TearDown]
        public void Cleanup()
        {
            driver.Close();
        }




    }
}

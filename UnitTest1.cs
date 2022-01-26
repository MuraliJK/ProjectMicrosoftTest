using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;
using System.Threading;

namespace MicrosoftProject
{
    public class DemoTest
    {
    
        [Test]
        public void Finance()
        {

            using (var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)))
            {

                driver.Navigate().GoToUrl(@"https://automatetheplanet.com/multiple-files-page-objects-item-templates/");
                driver.Manage().Window.Maximize();
                Thread.Sleep(5000);
                Assert.Pass();

            }
               
        }
    }
}
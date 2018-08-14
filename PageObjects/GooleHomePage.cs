using Bdd.Practice.Framework;
using Bdd.Practice.StepDefinitions;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace Bdd.Practice.PageObjects
{
    public class GoogleHomePage
    {
        public IWebElement SearchBox
        {
            get
            {
                return CustomDriver.driver.FindElement(By.Id("lst-ib"));
            }
        }

       // public IWebElement SubmitButton
        //{
          //  get
           // {
                
             //   return CustomDriver.driver.FindElement(By.Id("gs_htif0"));
            //}
        //}

        public IList<IWebElement> LinkElements
        {
            get
            {
                return CustomDriver.driver.FindElements(By.XPath("//div[@class='rc']/h3[@class='r']/a"));
            }
        }

        public void TriggerSearch(string text)
        {
            this.SearchBox.SendKeys(text);
            this.SearchBox.Submit();
          
            
            //this.SubmitButton.SendKeys(Keys.Enter);
        }
    }
}

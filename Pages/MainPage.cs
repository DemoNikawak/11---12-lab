using lab9_WebDriver.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_WebDriver.Pages
{
    public class MainPage
    {
        private Workspace _workspace;
        public MainPage(Workspace workspace)
        {
            _workspace = workspace;
        }

        private IWebElement _discounts => _workspace.findElementByXPath("//a[@class='nav-item h-discounts']");
        private IWebElement _sales => _workspace.findElementByXPath("//img[@title='Скидки']");
        private IWebElement _televisions => _workspace.findElementByXPath("//a[@href='/catalog/13-televizory-i-video']");
        private IWebElement _dropWhislist => _workspace.findElementByXPath("//a[@class='btn btn--index btn--block']");


        public void OpenDiscounts()
        {
            _discounts.Click();
        }
        public void OpenSales()
        {
            _sales.Click();
        }
        public void OpenTelevisions()
        {
            _televisions.Click();
        }
        public void OpenLikedProducts()
        {
            var likeElem = _workspace.findElementByXPath("//div[@class='n-item__icon ic-favorite']");
            likeElem.Click();
            _dropWhislist.Click();
        }
        public void Subscribe()
        {
            var input = _workspace.findElementByXPath("//div[@class='f-subscribe__form']//input");
            input.Click();

            input.SendKeys("nikawak228@gmail.com");

            var check = _workspace.findElementByXPath("//form//div[@data-v-1ad19bd8]//div[@class='inp-box__view']");
            check.Click();

            var btn = _workspace.findElementByXPath("//button[@data-v-1ad19bd8]");
            btn.Click();
        }
    }
}

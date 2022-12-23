using lab9_WebDriver.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_WebDriver.Pages
{
    public class AuthorizationPage
    {
        private Workspace _workspace;
        public AuthorizationPage(Workspace workspace)
        {
            _workspace = workspace;
        }


        private IWebElement _loginInput => _workspace.findElementByXPath("//input[@name='login']");
        private IWebElement _passwordInput => _workspace.findElementByXPath("//input[@type='password']");
        private IWebElement _enterButton => _workspace.findElementByXPath("//button[@class='btn btn--lg btn--block']//span[text()='Войти']");

        public void Authorize(UserModel user)
        {
            OpenAuthorizationPage();

            _loginInput.SendKeys(user.Phone);
            _passwordInput.SendKeys(user.Password);
            Thread.Sleep(1000);
            _enterButton.Click();

            Thread.Sleep(15000);
        }

        public void OpenAuthorizationPage()
        {
            Thread.Sleep(5000);
            _workspace.findElementByXPath("//a[@class='h-drop h-user']").Click();
        }
    }
}

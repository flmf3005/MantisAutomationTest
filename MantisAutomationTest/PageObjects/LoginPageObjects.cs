using MantisAutomationTest.Drivers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace MantisAutomationTest.PageObjects
{
    public class LoginPageObjects : WebDriver
    {
               
        public LoginPageObjects(IWebDriver driver)
        {
            
        }

        public IWebElement FldEntrar => driver.FindElement(By.XPath("//div[@id='login-box']/div/div/h4"));

        public IWebElement TxtUserName => driver.FindElement(By.Id("username"));

        public IWebElement BtnEntrar => driver.FindElement(By.XPath("//input[@value='Entrar']"));

        public IWebElement LnkNovaConta => driver.FindElement(By.LinkText("criar uma nova conta"));

        public IWebElement TxtSenha => driver.FindElement(By.Id("password"));

        public IWebElement LnkPerdeuSenha => driver.FindElement(By.LinkText("Perdeu a sua senha?"));

        public IWebElement BtnUserInfo => driver.FindElement(By.CssSelector("span.user-info"));


        public void inserirUsername()
        {
            try
            {
                Uteis.Uteis.preencherTxtField("administrator", TxtUserName);

                Uteis.Uteis.clicarBtn(BtnEntrar);

                Assert.AreEqual("Perdeu a sua senha?", LnkPerdeuSenha.Text);
            } catch (Exception e)
            {

            }
            

        }
    }
}

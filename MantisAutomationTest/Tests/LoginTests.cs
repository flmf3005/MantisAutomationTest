using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantisAutomationTest.Tests
{
    public class LoginTests : Drivers.WebDriver
    {

        [Test]
        public void acessarLoginPage()
        {
            PageObjects.LoginPageObjects loginPage = new PageObjects.LoginPageObjects(driver);

            Assert.AreEqual("Entrar", loginPage.FldEntrar.Text);
        }

        [Test]
        public void inserirUsername()
        {
            PageObjects.LoginPageObjects loginPage = new PageObjects.LoginPageObjects(driver);

            loginPage.inserirUsername();
                        
        }

        [Test]
        public void loginSucesso()
        {
            PageObjects.LoginPageObjects loginPage = new PageObjects.LoginPageObjects(driver);

            String usuario = "administrator";
            String senha = "qwe";

            Uteis.Uteis.preencherTxtField(usuario, loginPage.TxtUserName);

            Uteis.Uteis.clicarBtn(loginPage.BtnEntrar);

            Uteis.Uteis.preencherTxtField(senha, loginPage.TxtSenha);

            Uteis.Uteis.clicarBtn(loginPage.BtnEntrar);

            Assert.AreEqual(usuario, loginPage.BtnUserInfo.Text);
            
        }

    }
}

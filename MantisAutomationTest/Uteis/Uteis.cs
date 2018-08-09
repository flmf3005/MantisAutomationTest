using AventStack.ExtentReports;
using OpenQA.Selenium;
using System;
using System.IO;
using System.Reflection;

namespace MantisAutomationTest.Uteis
{
    class Uteis
    {
        public static String getPathSeleniumDriver()
        {
            // Função para definir o path do diretório
            String strAppDir = Path.GetDirectoryName(
            Assembly.GetExecutingAssembly().GetName().CodeBase).Substring(6);
            //String strAppFolderData = Path.Combine(strAppDir, "\\SeleniumComum\\Drivers");

            //Função para reduzir em duas camadas a arvore do path
            var gparent = Directory.GetParent(Directory.GetParent(strAppDir).ToString());

            //Conversão var -> String
            String aux = gparent.ToString();

            //Concatenar Path diretorio + Path Drivers
            String strAppFolderData = String.Concat(aux, "\\Drivers");

            return strAppFolderData; //+ strAppFolderData;
        }

        public static void preencherTxtField(String value, IWebElement element)
        {
            element.Clear();
            element.SendKeys(value);
        }

        public static void clicarBtn(IWebElement element)
        {
            try
            {
                element.Click();

            } catch (Exception e)
            {

            }
        }
    }
}

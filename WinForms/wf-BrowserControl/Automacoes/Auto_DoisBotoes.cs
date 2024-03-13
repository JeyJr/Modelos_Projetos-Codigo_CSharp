using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_BrowserControl.ManipularBotoes
{
    public class Auto_DoisBotoes
    {
        private string url = @"https://jj-tprojects.github.io/site-ToPlayground/pages/twoButtons.html";

        /// <summary>
        /// Automatizar click em dois btns em X tempos
        /// </summary>
        public void ManipularComponentesDoSiteEdge(int delayMM)
        {
            try
            {
                EdgeOptions edgeOptions = new EdgeOptions();

                edgeOptions.BinaryLocation = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe";
                //edgeOptions.AddArgument("--disable-notifications");
                //edgeOptions.AddExtension("caminho da extensao (renomeada ou nao) .crx"); //Encontre os arquivos da extensao, add para .zip depois renomeie para algum nome.crx
                IWebDriver driver = new EdgeDriver(edgeOptions);

                driver.Navigate().GoToUrl(url);

                while (IsDriverActive(driver))
                {
                    IWebElement btnCinzaEscuro = driver.FindElement(By.Id("btnCinzaEscuro"));
                    btnCinzaEscuro.Click();

                    Thread.Sleep(delayMM);

                    IWebElement btnCinza = driver.FindElement(By.Id("btnCinza"));
                    btnCinza.Click();

                    Thread.Sleep(delayMM);
                }

                driver.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool IsDriverActive(IWebDriver driver)
        {
            try
            {
                string title = driver.Title;
                return true;
            }
            catch (NoSuchWindowException)
            {
                return false;
            }
        }
    }
}

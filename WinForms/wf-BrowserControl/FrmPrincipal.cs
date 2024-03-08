using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace wf_BrowserControl
{
    public partial class FrmPrincipal : Form
    {
        private string url = @"https://jj-tprojects.github.io/site-TwoButtonPlayground/";

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void btnSite_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Verifica se existe uma janela com o nome especificado, se não existir, a mesma foi encerrada 
        /// </summary>
        private void IdentificarFechamentoDoSite()
        {
            try
            {
                Process.Start("msedge", "https://www.google.com");

                Thread.Sleep(2000);
                while (true)
                {
                    IntPtr browserWindowHandle = FindWindow(null, "Google");

                    if (browserWindowHandle != IntPtr.Zero)
                    {
                        Thread.Sleep(1000);
                    }
                    else
                        break;
                }

                MessageBox.Show("Browser fechado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Controle da instancia aberta e manipulação dos componentes do site
        /// </summary>
        private void ManipularComponentesDoSiteEdge()
        {
            try
            {
                EdgeOptions edgeOptions = new EdgeOptions();

                edgeOptions.BinaryLocation = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe";
                edgeOptions.AddArgument("--disable-notifications");
                IWebDriver driver = new EdgeDriver(edgeOptions);

                driver.Navigate().GoToUrl("https://jj-tprojects.github.io/site-TwoButtonPlayground/");

                while (IsDriverActive(driver))
                {
                    IWebElement btnCinzaEscuro = driver.FindElement(By.Id("btnCinzaEscuro"));
                    btnCinzaEscuro.Click();

                    Thread.Sleep(2000);

                    IWebElement btnCinza = driver.FindElement(By.Id("btnCinza"));
                    btnCinza.Click();

                    Thread.Sleep(2000);
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

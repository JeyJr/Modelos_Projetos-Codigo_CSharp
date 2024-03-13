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
using wf_BrowserControl.ManipularBotoes;

namespace wf_BrowserControl
{
    public partial class FrmPrincipal : Form
    {

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void btnSite_Click(object sender, EventArgs e)
        {
            Auto_DoisBotoes auto_DoisBotoes = new Auto_DoisBotoes();
            auto_DoisBotoes.ManipularComponentesDoSiteEdge(500);
        }


        // Verifica se existe uma janela com o nome especificado, se não existir, a mesma foi encerrada 
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
    }
}

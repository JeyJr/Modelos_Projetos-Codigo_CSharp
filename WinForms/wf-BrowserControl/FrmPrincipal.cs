using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_BrowserControl
{
    public partial class FrmPrincipal : Form
    {
        private string url = @"https://jj-tprojects.github.io/site-TwoButtonPlayground/";

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);


        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnBasicoProcessStart_Click(object sender, EventArgs e)
        {
            IdentificarFechamentoDoSite();
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

    }
}

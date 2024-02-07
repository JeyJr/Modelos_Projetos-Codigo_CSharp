using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_ValidationResult
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }


        private void Imprimir()
        {
            var imprimir = new Imprimir()
            {
                Assinatura = "JeyJr",
                TipoPapel = "A4",
                Documento = null,
            };

            var result = imprimir.Validate(imprimir, CultureInfo.CurrentCulture);

            if (result.IsValid)
            {
                MessageBox.Show("Objeto validado!");
            }
            else
            {
                MessageBox.Show(result.ErrorContent.ToString());
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }
    }
}

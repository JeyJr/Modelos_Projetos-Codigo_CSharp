using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerancaDeFormsComTiposGenericos
{
    public partial class FrmMini2 : Tela_Base.FrmBase
    {
        public FrmMini2()
        {
            InitializeComponent();
        }

        protected override void FecharTela()
        {
            base.FecharTela();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            FecharTela();
        }

        private void FrmMini2_FormClosed(object sender, FormClosedEventArgs e)
        {
            FecharTela();
        }
    }
}

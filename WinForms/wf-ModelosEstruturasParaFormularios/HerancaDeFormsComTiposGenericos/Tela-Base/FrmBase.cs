using HerancaDeFormsComTiposGenericos.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerancaDeFormsComTiposGenericos.Tela_Base
{
    public partial class FrmBase : Form, IFrmBase
    {
        protected IFrmGestor FrmGestor { get; set; }

        public FrmBase()
        {
            InitializeComponent();
        }

        public void ObterFrmGestor(IFrmGestor frmGestor)
        {
            FrmGestor = frmGestor;
        }

        protected virtual void FecharTela()
        {
            try
            {
                Type tipoClasseHerdeira = this.GetType();
                MethodInfo? metodoFecharFilho = FrmGestor.GetType().GetMethod("FecharFilho");
                metodoFecharFilho?.Invoke(FrmGestor, new object[] { tipoClasseHerdeira });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao tentar fechar tela\nErro: " + ex.Message);
            }
        }

        //Implementar atalhos

        //Implementar comportamentos padrão de telas bases
    }
}

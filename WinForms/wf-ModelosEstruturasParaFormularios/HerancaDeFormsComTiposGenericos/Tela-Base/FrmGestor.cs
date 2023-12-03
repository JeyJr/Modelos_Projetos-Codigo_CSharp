using HerancaDeFormsComTiposGenericos.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerancaDeFormsComTiposGenericos.Tela_Base
{
    public partial class FrmGestor : Tela_Base.FrmBase, IFrmGestor
    {
        protected List<FrmBase> filhosInstanciados = new List<FrmBase>();

        protected int limiteMaxFilhosInstanciados = 2;

        public FrmGestor()
        {
            InitializeComponent();
        }

        protected virtual void AbrirFilho<T>() where T : FrmBase, IFrmBase, new()
        {
            Type tipoT = typeof(T);
            FrmBase? filhoEncontrado = filhosInstanciados.FirstOrDefault(f => f.GetType() == tipoT);

            if (filhoEncontrado == null)
            {
                var novoFilho = new T();
                filhosInstanciados.Add(novoFilho);

                novoFilho.ObterFrmGestor(this);
                novoFilho.Show();
            }
            else
            {
                filhoEncontrado.Focus();
            }
        }

        public void FecharFilho(Type tipoClasseHerdeira)
        {
            FrmBase? filhoEncontrado = filhosInstanciados.FirstOrDefault(f => f.GetType() == tipoClasseHerdeira);

            if (filhoEncontrado != null)
            {
                filhosInstanciados.Remove(filhoEncontrado);
                filhoEncontrado.Close();
            }
        }
    }
}

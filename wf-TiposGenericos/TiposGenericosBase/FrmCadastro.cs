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

namespace TiposGenericosBase
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private object Entidade;

        public void ObterEntidade<T>() where T : class 
        {
            Entidade = Activator.CreateInstance<T>();
            this.Text = Entidade.GetType().Name;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Entidade == null) 
            {
                MessageBox.Show("Falha ao salvar!");
                return;
            }


            var propriedadeNomeDefinido = Entidade.GetType().GetProperty("Nome");

            if (propriedadeNomeDefinido != null && propriedadeNomeDefinido.PropertyType == typeof(string))
            {
                propriedadeNomeDefinido.SetValue(Entidade, txtNome.Text);
                FrmPrincipal.Registros.Add(Entidade);

                MessageBox.Show("Registro salvo!");
                this.Close();
            }
        }
    }
}

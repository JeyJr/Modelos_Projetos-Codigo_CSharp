using TiposGenericosBase.Entidades;

namespace TiposGenericosBase
{
    public partial class FrmPrincipal : Form
    {
        public static List<object> Registros = new List<object>();
        FrmCadastro FrmCadastro;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            FrmCadastro = new FrmCadastro();
            FrmCadastro.ObterEntidade<Marca>();
            FrmCadastro.Show();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            FrmCadastro = new FrmCadastro();
            FrmCadastro.ObterEntidade<Categoria>();
            FrmCadastro.Show();
        }

        private void btnEmbalagem_Click(object sender, EventArgs e)
        {
            FrmCadastro = new FrmCadastro();
            FrmCadastro.ObterEntidade<Embalagem>();
            FrmCadastro.Show();
        }
    }
}
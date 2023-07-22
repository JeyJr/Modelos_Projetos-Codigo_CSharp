using SimpleInjector;
using SimpleInjector_Basic.Interfaces;
using System.Drawing.Drawing2D;

namespace SimpleInjector_Basic
{
    public partial class FrmPrincipal : Form
    {

        Container container;
        IServicoDePessoas? servico;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        #region Metodos

        private void InicializarSimpleInjector()
        {
            container = new Container();
            container.Register<IRepositorioDePessoas, RepositorioDePessoas>();
            container.Register<IServicoDePessoas, ServicoDePessoas>();
            container.Verify();
            servico = container.GetInstance<IServicoDePessoas>();
        }

        private void InicializarDataGridView()
        {
            var colunaNome = new DataGridViewTextBoxColumn();
            var colunaIdade = new DataGridViewTextBoxColumn();

            colunaNome.HeaderText = "Nome";
            colunaIdade.HeaderText = "Idade";

            colunaNome.ReadOnly = true;
            colunaIdade.ReadOnly = true;

            colunaNome.Name = "colNome";
            colunaIdade.Name = "colIdade";

            colunaNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colunaIdade.Width = 90;

            dtgPessoas.Columns.Add(colunaNome);
            dtgPessoas.Columns.Add(colunaIdade);
        }

        #endregion Metodos

        #region Eventos

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            InicializarSimpleInjector();
            InicializarDataGridView();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
                return;

            if (nudIdade.Value == 0)
                return;

            servico.RegistrarPessoa((int)nudIdade.Value, txtNome.Text);

            txtNome.Clear();
            nudIdade.Value = 0;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dtgPessoas.Rows.Clear();

            txtNome.Clear();
            nudIdade.Value = 0;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<Pessoa> pessoas = servico.ObterTodasAsPessoas();

            dtgPessoas.Rows.Clear();

            foreach (Pessoa pessoa in pessoas)
                dtgPessoas.Rows.Add(pessoa.Nome, pessoa.Idade);
        }

        #endregion Eventos

    }
}
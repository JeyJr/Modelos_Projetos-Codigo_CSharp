using Dapper_Basic.Base;
using Dapper_Basic.Interfaces;
using Dapper_Basic.Repositorio;
using System.Text;

namespace Dapper_Basic
{
    public partial class FrmPrincipal : Form
    {
        IProdutoRepository produtoRepository;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        #region Metodos

        private void ExibirProdutosNoDataGrid(Produto produto, bool limparGrid = true)
        {
            if (limparGrid && dtgProduto.Rows.Count > 0)
                dtgProduto.Rows.Clear();

            dtgProduto.Rows.Add(
                produto.PK_ID,
                produto.NOME,
                produto.VALOR,
                produto.DESCRICAO,
                produto.ATIVO
                );

            AtualizarLabelStatus();
        }

        private void AtualizarLabelStatus()
        {
            lblStatus.Text = "Rows: " + dtgProduto.Rows.Count.ToString();
        }


        #endregion Metodos

        #region Eventos

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            string stringConexao = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            produtoRepository = new ProdutoRepository(stringConexao);
        }

        //Formatação dos TextBox
        private void txtBoxNumerosInteiros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBoxApenasNumerosComCasasDecimais_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ';')
            {
                e.KeyChar = ',';
            }

            if (((TextBox)sender).Text.Contains(',') && e.KeyChar == ',')
            {
                e.Handled = true;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBoxLimitarCasasDecimais_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox is null)
                return;

            if (string.IsNullOrWhiteSpace(textBox.Text))
                return;

            decimal valor = Convert.ToDecimal(textBox.Text);
            valor = Math.Round(valor, 2);
            textBox.Text = valor.ToString();
        }


        //Btns
        private void btnAtualizarLabelStatus_Click(object sender, MouseEventArgs e)
        {
            AtualizarLabelStatus();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            IEnumerable<Produto> itens = produtoRepository.ObterTodosProdutos();
            //dtgProduto.DataSource = itens;

            if (dtgProduto.Rows.Count > 0)
                dtgProduto.Rows.Clear();

            itens.OrderBy(i => i.NOME)
                .ToList()
                .ForEach(i => ExibirProdutosNoDataGrid(i, false));
        }

        private void btnPesquisarID_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxID.Text))
                return;

            int id = Convert.ToInt16(txtBoxID.Text.Trim());

            Produto item = produtoRepository.ObterProdutoPorId(id);

            if (item is null)
                return;

            ExibirProdutosNoDataGrid(item);

            //List<Produto> listaProdutos = new List<Produto> { item };
            //dtgProduto.DataSource = listaProdutos;

            //listaProdutos.OrderBy(p => p.NOME)
            //    .ToList()
            //    .ForEach(p => ExibirProdutosNoDataGrid(p));
        }

        private void btnPesquisaPersonalizada_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string preco = txtPreco.Text;
            string descricao = txtDescricao.Text;

            string sql = " NOME LIKE '%" + nome.Trim() + "%' ";

            if (!string.IsNullOrWhiteSpace(preco) )
                sql += "    AND VALOR = " + preco;

            if (!string.IsNullOrWhiteSpace(descricao))
                sql += "    AND DESCRICAO LIKE '%" + descricao.Trim() + "%'";

            var itens = produtoRepository.ObterLista(sql);

            if (itens is null)
                return;

            dtgProduto.Rows.Clear();
            itens.OrderBy(i => i.NOME).ToList().ForEach(i => ExibirProdutosNoDataGrid(i, false));
        }
        #endregion Eventos

    }
}
using System.Data;
using System.Drawing.Text;

namespace wf_ComboBox_basic
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        BindingSource bindingSource = new BindingSource();
        private List<Produto> produtos = new List<Produto>();

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            var dt = Tabela.ObterTabela();

            foreach (DataRow row in dt.Rows)
            {
                Produto produto = new Produto
                {
                    ID = Convert.ToInt32(row["ID"].ToString()),
                    Nome = row["Nome"].ToString()
                };

                produtos.Add(produto);
            }
        }

        bool teste = false;

        private void cbo1_TextChanged(object sender, EventArgs e)
        {
            //Essa solucao faz com que o ListBox1 faca o papel do autocomplete
            if(cbo1.Text.Length > 3) 
            {
                string filtro = cbo1.Text;

                var itensFiltrados = produtos
                    .Where(produto => produto.Nome.Contains(filtro))
                    .Select(produto => produto.Nome)
                    .ToArray();

                listBox1.Items.Clear();
                listBox1.Items.AddRange(itensFiltrados);
            }
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {

        }

        private void Exemplo1()
        {
            //Exemplo utiliza um bindingSource para guardar a base original e
            //realizar os filtros conforme o que o usuario digita

            string filtro = cbo1.Text;
            bindingSource.Filter = $"Nome LIKE '{filtro}%'";
            IEnumerable<Produto> colecao;

            if (bindingSource.Current != null)
            {
                DataRowView currentRow = (DataRowView)bindingSource.Current;

                List<string> items = new List<string>();

                foreach (DataRowView row in currentRow.DataView)
                {
                    items.Add(row["Nome"].ToString());
                }

                cbo1.AutoCompleteCustomSource.AddRange(items.ToArray());
                cbo1.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbo1.AutoCompleteSource = AutoCompleteSource.CustomSource;

                cbo1.Select(cbo1.Text.Length, 0);
            }
        }
        private void Exemplo2()
        {
            if (cbo1.Text.Length >= 3)
            {
                string filtro = cbo1.Text;

                // Filtrar a coleção de produtos com base no texto do ComboBox
                var itensFiltrados = produtos
                    .Where(produto => produto.Nome.Contains(filtro))
                    .ToList();

                // Atribuir os itens filtrados como DataSource do ComboBox
                cbo1.DataSource = itensFiltrados;
                cbo1.DisplayMember = "Nome";
                cbo1.ValueMember = "ID";

                // Exibir a lista suspensa do ComboBox
                cbo1.DroppedDown = true;
            }
        }
        private void Exemplo3()
        {
            string filtro = cbo1.Text;

            if (filtro.Length < 3)
            {
                // Desativar o AutoComplete personalizado
                cbo1.AutoCompleteMode = AutoCompleteMode.None;
                cbo1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            else
            {
                // Ativar o AutoComplete personalizado
                cbo1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

                // Filtrar a coleção de produtos com base no texto do ComboBox
                var itensFiltrados = produtos
                    .Where(produto => produto.Nome.Contains(filtro))
                    .Select(produto => produto.Nome)
                    .ToArray();

                // Configure o AutoCompleteCustomSource com os itens filtrados
                var autoCompleteCollection = new AutoCompleteStringCollection();
                autoCompleteCollection.AddRange(itensFiltrados);
                cbo1.AutoCompleteCustomSource = autoCompleteCollection;

                cbo1.DroppedDown = true;
            }

        }
        private void Exemplo4()
        {
            List<string> sugestoesPersonalizadas = new List<string>
                {
                    "Sugestão 1",
                    "Sugestão 2",
                    "Sugestão 3"
                    // Adicione suas sugestões personalizadas aqui
                };

            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            // Criar uma coleção de sugestões personalizadas
            autoCompleteCollection.AddRange(sugestoesPersonalizadas.ToArray());
            // Configurar o AutoCompleteCustomSource com a coleção personalizada
            cbo1.AutoCompleteCustomSource = autoCompleteCollection;

            cbo1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbo1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }
    }
}

class Produto
{
    public int ID { get; set; }
    public string Nome { get; set; }
}

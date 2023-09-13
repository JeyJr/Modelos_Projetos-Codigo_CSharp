using System.Data;
using System.Drawing.Text;

namespace wf_ComboBox_AutoComplete_Com_ListView
{
    public partial class FrmPrincipal : Form
    {
        DataTable dadosOriginais = new DataTable();
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        #region Metodos
        private void BindAutoComplete(string filtro)
        {
            listView1.Items.Clear();

            if (filtro.Trim() == "")
            {
                dadosOriginais.Rows
                .OfType<DataRow>()
                .ToList()
                .ForEach(item => listView1.Items.Add(item["Nome"].ToString().ToLower().Trim()));
            }
            else
            {
                dadosOriginais.Rows
                .OfType<DataRow>()
                .ToList()
                .ForEach(item =>
                {
                    string n = item["Nome"].ToString().ToLower().Trim();
                    string f = filtro.ToLower().Trim();

                    if (n.Contains(f))
                    {
                        listView1.Items.Add(item["Nome"].ToString());
                    }
                });
            }

            listView1.Visible = listView1.Items.Count > 0;
        }
        private void SelecionarItemDoAutoComplete()
        {
            if (listView1.SelectedItems != null)
            {
                string itemSelecionado = listView1.SelectedItems[0].Text;
                int indice = comboBox1.FindString(itemSelecionado);

                if (indice != -1)
                {
                    comboBox1.SelectedIndex = indice;
                    listView1.Visible = false;
                }
            }
        }
        #endregion Metodos

        #region Eventos
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            dadosOriginais = Tabela.ObterTabela();

            comboBox1.DataSource = dadosOriginais;
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "Nome";

            comboBox1.Text = "";
        }
        /* comboBox */
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Length > 0)
            {
                BindAutoComplete(comboBox1.Text);
            }
            else
            {
                listView1.Visible = false;
            }
        }
        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            /* Não permite navegar nos items do comboBox */
            /* A "Navegação" só será permitida no ListViewr */

            if (e.KeyCode == Keys.Up)
            {
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (listView1.Items.Count > 0 && listView1.Visible)
                {
                    listView1.Focus();
                    listView1.Items[0].Selected = true;
                }

                e.Handled = true;
            }
        }
        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (!listView1.Focused && !comboBox1.Focused)
                listView1.Visible = false;
        }

        /* listView */
        private void listView1_Click(object sender, EventArgs e)
        {
            SelecionarItemDoAutoComplete();
        }
        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            /* Quando chegar no indice 0 retorna para o comboBox */

            if (e.KeyCode == Keys.Enter)
            {
                SelecionarItemDoAutoComplete();
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (listView1.Items.Count > 0 && listView1.Items[0].Selected)
                {
                    comboBox1.Focus();
                    comboBox1.Select(comboBox1.Text.Length, 0);
                }
            }
        }
        #endregion Eventos

    }
}

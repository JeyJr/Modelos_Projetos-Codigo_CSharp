using System.Data;
using System.Drawing.Text;

namespace wf_ComboBox_AutoComplete_Com_ListView
{
    public partial class FrmPrincipal : Form
    {
        DataTable dadosOriginais = new DataTable();

        string textDigitado = "";
        bool dropdownAberto = false;
        private int ID = 0;
        private string Nome = "";

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        #region Metodos
        private void BindAutoComplete()
        {
            listView1.Items.Clear();
            string filtro = comboBox1.Text.Trim();

            if (filtro.Trim() == "")
            {
                dadosOriginais.Rows
                .OfType<DataRow>()
                .ToList()
                .ForEach(item => listView1.Items.Add(item["Nome"].ToString()));
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
        }
        private void SelecionarItemDoAutoComplete()
        {
            if (listView1.SelectedItems != null)
            {
                string itemSelecionado = listView1.SelectedItems[0].Text;
                comboBox1.Text = itemSelecionado;
                //int indice = comboBox1.FindString(itemSelecionado);

                foreach (DataRow row in dadosOriginais.Rows)
                {
                    if (row["Nome"].ToString() == itemSelecionado)
                    {
                        ID = Convert.ToInt32(row["ID"].ToString());
                        Nome = row["Nome"].ToString();

                        break;
                    }
                }
                FecharAutoComplete();
            }
        }
        private void ExibirAutoComplete()
        {
            BindAutoComplete();
            listView1.Visible = true;
        }
        private void FecharAutoComplete()
        {
            listView1.Visible = false;
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

            //this.Click += FecharAutoComplete_Click;
        }
        private void FecharAutoComplete_Click(object sender, EventArgs e)
        {
            FecharAutoComplete();
        }

        /* comboBox */
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Length > 0)
            {
                if (dropdownAberto)
                {
                    textDigitado = comboBox1.Text;
                    comboBox1.Text = "";
                    comboBox1.DropDownHeight = 1;
                    comboBox1.DroppedDown = false;

                    if (comboBox1.SelectedItem == null)
                    {
                        comboBox1.Text = textDigitado;
                        comboBox1.Select(comboBox1.Text.Length, 0);
                        ExibirAutoComplete();
                    }
                }
                else
                {
                    ExibirAutoComplete();
                }
            }
            else
            {
                FecharAutoComplete();
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
                ExibirAutoComplete();

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
            //if (!listView1.Focused && !comboBox1.Focused)
            //    FecharAutoComplete();
        }
        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            FecharAutoComplete();
            comboBox1.DropDownHeight = 140;
            
            dropdownAberto = true;
        }
        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            comboBox1.DropDownHeight = 1;

            dropdownAberto = false;
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

                    if (comboBox1.Text.Length <= 0)
                    {
                        FecharAutoComplete();
                    }
                }
            }
        }

        #endregion Eventos
    }
}

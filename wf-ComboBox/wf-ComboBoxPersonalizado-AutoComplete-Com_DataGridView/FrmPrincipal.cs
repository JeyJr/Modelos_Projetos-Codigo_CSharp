using System.Data;
using wf_ComboBox_AutoComplete_Com_ListView;

namespace wf_ComboBoxPersonalizado_AutoComplete_Com_ListView
{
    public partial class FrmPrincipal : Form
    {
        AutoCompleteComboBoxPersonalizado autoCompleteCboPersonalizado = new AutoCompleteComboBoxPersonalizado();
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            AutoComplete();
            autoCompleteCboPersonalizado.AtribuirDataSource(Tabela.ObterTabela(), false);
        }
        private void AutoComplete()
        {
            autoCompleteCboPersonalizado.AtribuirComboBox(
                this,
                ref cboPersonalizado,
                ref btnCboPersonalizado,
                ref txtCboPersonalizado,
                new DataGridViewColumn[]
                {
                      new DataGridViewTextBoxColumn{
                            DataPropertyName = "ID",
                            HeaderText = "PK_Item",
                            MinimumWidth = 100,
                            Name = "colPK_Item",
                            ReadOnly = true,
                            Visible = false,
                      },

                      new DataGridViewTextBoxColumn
                      {
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                        DataPropertyName = "Nome",
                        HeaderText = "Nome",
                        Name = "colNomeItem",
                        ReadOnly = true,
                       }
                },
                cboPersonalizado.Size.Width, 150, "colNomeItem");
        }
        private void txtCboPersonalizado_TextChanged(object sender, EventArgs e)
        {
            if (txtCboPersonalizado.Text.Length > 0)
            {
                var dt = new DataTable();
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Nome", typeof(string));

                Tabela.ObterTabela()
                    .Rows
                    .OfType<DataRow>()
                    .ToList()
                    .ForEach(item =>
                    {
                        string i = item["Nome"].ToString().ToLower().Trim();
                        string f = txtCboPersonalizado.Text.ToLower().Trim();

                        if (i.Contains(f))
                        {
                            dt.Rows.Add(item.ItemArray);
                        }
                    });

                autoCompleteCboPersonalizado.AtribuirDataSource(dt, true);
            }
            else
            {
                autoCompleteCboPersonalizado.AtribuirDataSource(Tabela.ObterTabela(), true);
            }
        }
    }
}
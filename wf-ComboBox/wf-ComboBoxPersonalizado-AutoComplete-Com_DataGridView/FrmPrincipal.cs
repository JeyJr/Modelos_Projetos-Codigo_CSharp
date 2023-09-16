using System.Data;
using wf_ComboBox_AutoComplete_Com_ListView;

namespace wf_ComboBoxPersonalizado_AutoComplete_Com_ListView
{
    public partial class FrmPrincipal : Form
    {
        AutoCompleteCboPersonalizado autoCompleteCboPersonalizado = new AutoCompleteCboPersonalizado();
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
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
                cboPersonalizado.Size.Width,
                150);


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

                autoCompleteCboPersonalizado.AtribuirDataSource(dt);
            }
            else
            {
                autoCompleteCboPersonalizado.AtribuirDataSource(Tabela.ObterTabela());
            }
        }
    }
}
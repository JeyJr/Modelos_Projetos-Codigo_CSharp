using SimpleInject_Basic_SqlServer.SQL;
using SimpleInject_Basic_SqlServer.SQL.Interfaces;
using SimpleInjector;
using System.Data;

namespace SimpleInject_Basic_SqlServer
{
    public partial class FrmPrincipal : Form
    {
        Container container;
        ICRUDSimples? crudSimples;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        #region Metodos

        private void InicializarSimpleInjection()
        {
            container = new Container();
            container.Register<IConexaoBancoDeDados, ConexaoBancoDeDados>();
            container.Register<ICRUDSimples, CRUDSimples>();
            container.Verify();

            crudSimples = container.GetInstance<ICRUDSimples>();
        }
        
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            InicializarSimpleInjection();
        }

        #endregion Metodos

        #region Eventos
        
        private void btnExecutar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtConsulta.Text))
                    return;

                string sql = txtConsulta.Text.ToUpper();
                int result = 0;

                if (sql.Contains("UPDATE"))
                {
                    result = crudSimples.Update(sql);
                }
                else if (sql.Contains("DELETE"))
                {
                    result = crudSimples.Delete(sql);
                }
                else if (sql.Contains("INSERT"))
                {
                    result = crudSimples.Delete(sql);
                }
                else if (sql.Contains("SELECT"))
                {
                    DataTable dt = crudSimples.Select(sql);

                    if (dt.Rows.Count <= 0)
                        return;

                    dtgPrincipal.Columns.Clear(); 

                    foreach (DataColumn dc in dt.Columns)
                    {
                        var coluna = new DataGridViewTextBoxColumn();
                        coluna.HeaderText = dc.ColumnName;
                        coluna.Name = dc.ColumnName;
                        dtgPrincipal.Columns.Add(coluna);
                    }

                    foreach (DataRow dr in dt.Rows)
                    {
                        object[] rowData = dr.ItemArray;
                        dtgPrincipal.Rows.Add(rowData);
                    }

                    result = 1;
                }


                if (result > 0)
                {
                    MessageBox.Show("Consulta realizada com sucesso!");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }  
        }

        #endregion Eventos
    }
}
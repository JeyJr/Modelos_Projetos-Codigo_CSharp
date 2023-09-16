using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_ComboBoxPersonalizado_AutoComplete_Com_ListView
{
    public partial class AutoCompleteCboPersonalizado : UserControl
    {
        private TableLayoutPanel cboPersonalizado;
        private Button btnCboPersonalizado;
        private TextBox txtCboPersonalizado;

        private DataGridViewCellStyle estiloOriginalDaCelula;
        public AutoCompleteCboPersonalizado()
        {
            InitializeComponent();

            dataGridView1.CellMouseEnter += dataGridView1_CellMouseEnter;
            dataGridView1.CellMouseLeave += dataGridView1_CellMouseLeave;
        }

        public void AtribuirComboBox(Control control, ref TableLayoutPanel cboPersonalizado, ref Button btnCboPersonlizado, ref TextBox txtCboPersonlizado, DataGridViewColumn[] colunas, int tamanhoX, int tamanhoY)
        {
            this.cboPersonalizado = cboPersonalizado;
            this.btnCboPersonalizado = btnCboPersonlizado;
            this.txtCboPersonalizado = txtCboPersonlizado;

            if(colunas.Length > 0 )
            {
                foreach (var coluna in colunas)
                {
                    dataGridView1.Columns.Add(coluna);
                }
            }

            control.Controls.Add(this);

            int locationY = cboPersonalizado.Height + cboPersonalizado.Location.Y;

            this.Location = new Point(cboPersonalizado.Location.X, locationY);
            this.Size = new Size(tamanhoX, tamanhoY);
            
            this.Show();
            this.Visible = false;

            this.btnCboPersonalizado.Click += btnCboPersonalizado_Click;
        }
        public void AtribuirDataSource(DataTable dataSource)
        {
            dataGridView1.DataSource = dataSource;
            this.Visible = dataSource != null;
        }
        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewCellStyle novoEstilo = new DataGridViewCellStyle
                {
                    BackColor = Color.FromArgb(50, 82, 39),
                    ForeColor = Color.White
                };

                dataGridView1.Rows[e.RowIndex].DefaultCellStyle = novoEstilo;
            }
        }
        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle = estiloOriginalDaCelula;
            }
        }
        private void btnCboPersonalizado_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
        }
    }
}

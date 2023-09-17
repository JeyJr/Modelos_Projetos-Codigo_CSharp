using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_ComboBoxPersonalizado_AutoComplete_Com_ListView
{
    public class AutoCompleteComboBoxPersonalizado
    {
        private TableLayoutPanel cboPersonalizado;
        private Button btnCboPersonalizado;
        private TextBox txtCboPersonalizado;
        private DataGridViewCellStyle estiloOriginalDaCelula;
        private DataGridView dataGridView1;

        /// <summary>
        /// Nome da coluna que será exibida no textBox
        /// </summary>
        private string NomeDaColuna = "";

        public AutoCompleteComboBoxPersonalizado()
        {

        }

        public void AtribuirComboBox(Control control, ref TableLayoutPanel cboPersonalizado, ref Button btnCboPersonlizado, ref TextBox txtCboPersonlizado, DataGridViewColumn[] colunas, int tamanhoX, int tamanhoY, string nomeDaColuna)
        {
            this.cboPersonalizado = cboPersonalizado;
            this.btnCboPersonalizado = btnCboPersonlizado;
            this.txtCboPersonalizado = txtCboPersonlizado;
            ContruirDataGrid();
            if (colunas.Length > 0)
            {
                foreach (var coluna in colunas)
                {
                    dataGridView1.Columns.Add(coluna);
                }
            }

            control.Controls.Add(dataGridView1);

            int locationY = cboPersonalizado.Height + cboPersonalizado.Location.Y;

            dataGridView1.Location = new Point(cboPersonalizado.Location.X, locationY);
            dataGridView1.Size = new Size(tamanhoX, tamanhoY);

            dataGridView1.Show();
            dataGridView1.Visible = true;
            NomeDaColuna = nomeDaColuna;
            this.btnCboPersonalizado.Click += btnCboPersonalizado_Click;
            this.txtCboPersonalizado.Leave += txtCboPersonalizado_Leave;
        }

        private void ContruirDataGrid()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 235, 235);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.FromArgb(235, 235, 235);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(60, 74, 84);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(47, 59, 67);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(246, 246, 246);
            dataGridViewCellStyle3.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(140, 200, 120);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Dock = DockStyle.None;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(217, 217, 217);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 55;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(337, 274);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            dataGridView1.VisibleChanged += dataGridView1_VisibleChanged;
            dataGridView1.Click += dataGridView1_Click;
            dataGridView1.CellMouseEnter += dataGridView1_CellMouseEnter;
            dataGridView1.CellMouseLeave += dataGridView1_CellMouseLeave;
        }
        public void AtribuirDataSource(DataTable dataSource)
        {
            AtribuirDataSource(dataSource, false);
        }
        public void AtribuirDataSource(DataTable dataSource, bool exibirGrid = true)
        {
            dataGridView1.DataSource = dataSource;
            dataGridView1.Visible = dataSource != null && exibirGrid;
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
            dataGridView1.Visible = !dataGridView1.Visible;
        }
        private void txtCboPersonalizado_Leave(object sender, EventArgs e)
        {
            if (dataGridView1.Visible)
            {
                dataGridView1.Visible = false;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    var item = dataGridView1.Rows[e.RowIndex].Cells[NomeDaColuna].Value as string;

            //    if (item != null)
            //    {
            //        txtCboPersonalizado.Text = item;
            //    }
            //}

            //if (this.Visible)
            //{
            //    this.Visible = false;
            //}
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;

            if (dataGridView != null && dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                int rowIndex = selectedRow.Index;


                string item = selectedRow.Cells[NomeDaColuna].Value as string;
                txtCboPersonalizado.Text = item;
            }
        }

        private void dataGridView1_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void AutoCompleteCboPersonalizado_VisibleChanged(object sender, EventArgs e)
        {

        }
    }
}

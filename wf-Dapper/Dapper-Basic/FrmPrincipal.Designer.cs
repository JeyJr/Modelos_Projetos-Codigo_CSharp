namespace Dapper_Basic
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnExibir = new Button();
            dtgProduto = new DataGridView();
            colPK_ID = new DataGridViewTextBoxColumn();
            colNome = new DataGridViewTextBoxColumn();
            colPreco = new DataGridViewTextBoxColumn();
            colDescricao = new DataGridViewTextBoxColumn();
            colAtivo = new DataGridViewTextBoxColumn();
            btnPesquisarID = new Button();
            txtBoxID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgProduto).BeginInit();
            SuspendLayout();
            // 
            // btnExibir
            // 
            btnExibir.Location = new Point(539, 117);
            btnExibir.Name = "btnExibir";
            btnExibir.Size = new Size(156, 29);
            btnExibir.TabIndex = 0;
            btnExibir.Text = "Todos Produtos";
            btnExibir.UseVisualStyleBackColor = true;
            btnExibir.Click += btnExibir_Click;
            // 
            // dtgProduto
            // 
            dtgProduto.AllowUserToAddRows = false;
            dtgProduto.AllowUserToDeleteRows = false;
            dtgProduto.AllowUserToResizeColumns = false;
            dtgProduto.AllowUserToResizeRows = false;
            dtgProduto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgProduto.ColumnHeadersHeight = 35;
            dtgProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgProduto.Columns.AddRange(new DataGridViewColumn[] { colPK_ID, colNome, colPreco, colDescricao, colAtivo });
            dtgProduto.EnableHeadersVisualStyles = false;
            dtgProduto.Location = new Point(12, 152);
            dtgProduto.Name = "dtgProduto";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dtgProduto.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dtgProduto.RowHeadersVisible = false;
            dtgProduto.RowHeadersWidth = 50;
            dtgProduto.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgProduto.RowTemplate.Height = 29;
            dtgProduto.Size = new Size(683, 330);
            dtgProduto.TabIndex = 1;
            // 
            // colPK_ID
            // 
            colPK_ID.HeaderText = "PK_ID";
            colPK_ID.MinimumWidth = 6;
            colPK_ID.Name = "colPK_ID";
            colPK_ID.Visible = false;
            colPK_ID.Width = 125;
            // 
            // colNome
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.Padding = new Padding(0, 5, 0, 0);
            colNome.DefaultCellStyle = dataGridViewCellStyle2;
            colNome.HeaderText = "Produto";
            colNome.MinimumWidth = 6;
            colNome.Name = "colNome";
            colNome.ReadOnly = true;
            colNome.Width = 200;
            // 
            // colPreco
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.Format = "R$ ###.##0";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.Padding = new Padding(0, 0, 5, 0);
            colPreco.DefaultCellStyle = dataGridViewCellStyle3;
            colPreco.HeaderText = "Preço";
            colPreco.MinimumWidth = 6;
            colPreco.Name = "colPreco";
            colPreco.ReadOnly = true;
            colPreco.Width = 140;
            // 
            // colDescricao
            // 
            colDescricao.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.Padding = new Padding(0, 3, 0, 0);
            colDescricao.DefaultCellStyle = dataGridViewCellStyle4;
            colDescricao.HeaderText = "Descrição";
            colDescricao.MinimumWidth = 6;
            colDescricao.Name = "colDescricao";
            colDescricao.ReadOnly = true;
            // 
            // colAtivo
            // 
            colAtivo.HeaderText = "Ativo";
            colAtivo.MinimumWidth = 6;
            colAtivo.Name = "colAtivo";
            colAtivo.ReadOnly = true;
            colAtivo.Visible = false;
            colAtivo.Width = 125;
            // 
            // btnPesquisarID
            // 
            btnPesquisarID.Location = new Point(143, 115);
            btnPesquisarID.Name = "btnPesquisarID";
            btnPesquisarID.Size = new Size(156, 29);
            btnPesquisarID.TabIndex = 2;
            btnPesquisarID.Text = "Pesquisar ID";
            btnPesquisarID.UseVisualStyleBackColor = true;
            btnPesquisarID.Click += btnPesquisarID_Click;
            // 
            // txtBoxID
            // 
            txtBoxID.Location = new Point(12, 117);
            txtBoxID.Name = "txtBoxID";
            txtBoxID.Size = new Size(125, 27);
            txtBoxID.TabIndex = 3;
            txtBoxID.KeyPress += txtBoxNumerosInteiros_KeyPress;
            txtBoxID.Leave += txtBoxLimitarCasasDecimais_Leave;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 505);
            Controls.Add(txtBoxID);
            Controls.Add(btnPesquisarID);
            Controls.Add(dtgProduto);
            Controls.Add(btnExibir);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            Load += FrmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dtgProduto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExibir;
        private DataGridView dtgProduto;
        private Button btnPesquisarID;
        private TextBox txtBoxID;
        private DataGridViewTextBoxColumn colPK_ID;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colPreco;
        private DataGridViewTextBoxColumn colDescricao;
        private DataGridViewTextBoxColumn colAtivo;
    }
}
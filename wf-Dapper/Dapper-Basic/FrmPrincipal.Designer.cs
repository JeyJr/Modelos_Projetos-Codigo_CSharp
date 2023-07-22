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
            txtNome = new TextBox();
            txtPreco = new TextBox();
            txtDescricao = new TextBox();
            btnPesquisaPersonalizada = new Button();
            lblPesquisarID = new Label();
            lblNome = new Label();
            lblPreco = new Label();
            lblDescricao = new Label();
            lblStatus = new Label();
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
            btnExibir.MouseClick += btnAtualizarLabelStatus_Click;
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
            btnPesquisarID.MouseClick += btnAtualizarLabelStatus_Click;
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
            // txtNome
            // 
            txtNome.Location = new Point(12, 46);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 4;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(143, 46);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(139, 27);
            txtPreco.TabIndex = 5;
            txtPreco.KeyPress += txtBoxApenasNumerosComCasasDecimais_KeyPress;
            txtPreco.Leave += txtBoxLimitarCasasDecimais_Leave;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(288, 46);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(245, 27);
            txtDescricao.TabIndex = 6;
            // 
            // btnPesquisaPersonalizada
            // 
            btnPesquisaPersonalizada.Location = new Point(539, 46);
            btnPesquisaPersonalizada.Name = "btnPesquisaPersonalizada";
            btnPesquisaPersonalizada.Size = new Size(156, 29);
            btnPesquisaPersonalizada.TabIndex = 7;
            btnPesquisaPersonalizada.Text = "Pesquisar";
            btnPesquisaPersonalizada.UseVisualStyleBackColor = true;
            btnPesquisaPersonalizada.Click += btnPesquisaPersonalizada_Click;
            btnPesquisaPersonalizada.MouseClick += btnAtualizarLabelStatus_Click;
            // 
            // lblPesquisarID
            // 
            lblPesquisarID.AutoSize = true;
            lblPesquisarID.Location = new Point(12, 94);
            lblPesquisarID.Name = "lblPesquisarID";
            lblPesquisarID.Size = new Size(24, 20);
            lblPesquisarID.TabIndex = 8;
            lblPesquisarID.Text = "ID";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(12, 23);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 20);
            lblNome.TabIndex = 9;
            lblNome.Text = "Nome";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(143, 23);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(46, 20);
            lblPreco.TabIndex = 10;
            lblPreco.Text = "Preço";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(288, 23);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(74, 20);
            lblDescricao.TabIndex = 11;
            lblDescricao.Text = "Descrição";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 485);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(66, 20);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "lblStatus";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 505);
            Controls.Add(lblStatus);
            Controls.Add(lblDescricao);
            Controls.Add(lblPreco);
            Controls.Add(lblNome);
            Controls.Add(lblPesquisarID);
            Controls.Add(btnPesquisaPersonalizada);
            Controls.Add(txtDescricao);
            Controls.Add(txtPreco);
            Controls.Add(txtNome);
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
        private TextBox txtNome;
        private TextBox txtPreco;
        private TextBox txtDescricao;
        private Button btnPesquisaPersonalizada;
        private Label lblPesquisarID;
        private Label lblNome;
        private Label lblPreco;
        private Label lblDescricao;
        private Label lblStatus;
    }
}
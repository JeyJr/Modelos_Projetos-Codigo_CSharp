namespace API_ModeloSimples
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
            btnExecutar = new Button();
            dtgMusica = new DataGridView();
            Nome = new DataGridViewTextBoxColumn();
            Artista = new DataGridViewTextBoxColumn();
            Genero = new DataGridViewTextBoxColumn();
            Duracao = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgMusica).BeginInit();
            SuspendLayout();
            // 
            // btnExecutar
            // 
            btnExecutar.Location = new Point(763, 12);
            btnExecutar.Name = "btnExecutar";
            btnExecutar.Size = new Size(143, 45);
            btnExecutar.TabIndex = 0;
            btnExecutar.Text = "Executar";
            btnExecutar.UseVisualStyleBackColor = true;
            btnExecutar.Click += btnExecutar_Click;
            // 
            // dtgMusica
            // 
            dtgMusica.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgMusica.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgMusica.Columns.AddRange(new DataGridViewColumn[] { Nome, Artista, Genero, Duracao });
            dtgMusica.Location = new Point(12, 77);
            dtgMusica.Name = "dtgMusica";
            dtgMusica.RowTemplate.Height = 25;
            dtgMusica.Size = new Size(894, 343);
            dtgMusica.TabIndex = 1;
            // 
            // Nome
            // 
            Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // Artista
            // 
            Artista.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Artista.DataPropertyName = "Artista";
            Artista.HeaderText = "Artista";
            Artista.Name = "Artista";
            // 
            // Genero
            // 
            Genero.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Genero.DataPropertyName = "Genero";
            Genero.HeaderText = "Genero";
            Genero.Name = "Genero";
            // 
            // Duracao
            // 
            Duracao.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Duracao.DataPropertyName = "Duracao";
            Duracao.HeaderText = "Duracao";
            Duracao.Name = "Duracao";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 432);
            Controls.Add(dtgMusica);
            Controls.Add(btnExecutar);
            Name = "FrmPrincipal";
            Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)dtgMusica).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExecutar;
        private DataGridView dtgMusica;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Artista;
        private DataGridViewTextBoxColumn Genero;
        private DataGridViewTextBoxColumn Duracao;
    }
}
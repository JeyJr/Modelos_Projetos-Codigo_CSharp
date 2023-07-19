namespace SimpleInjector_Basic
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
            lblNome = new Label();
            txtNome = new TextBox();
            nudIdade = new NumericUpDown();
            btnRegistrar = new Button();
            btnLimpar = new Button();
            lblIdade = new Label();
            dtgPessoas = new DataGridView();
            btnListar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudIdade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgPessoas).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.Location = new Point(12, 13);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(333, 21);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            lblNome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 36);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(333, 27);
            txtNome.TabIndex = 2;
            // 
            // nudIdade
            // 
            nudIdade.Location = new Point(351, 36);
            nudIdade.Name = "nudIdade";
            nudIdade.Size = new Size(112, 27);
            nudIdade.TabIndex = 5;
            nudIdade.TextAlign = HorizontalAlignment.Right;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(369, 79);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(12, 79);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(94, 29);
            btnLimpar.TabIndex = 7;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lblIdade
            // 
            lblIdade.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblIdade.Location = new Point(351, 9);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(112, 25);
            lblIdade.TabIndex = 8;
            lblIdade.Text = "Idade";
            lblIdade.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtgPessoas
            // 
            dtgPessoas.AllowUserToAddRows = false;
            dtgPessoas.AllowUserToDeleteRows = false;
            dtgPessoas.AllowUserToOrderColumns = true;
            dtgPessoas.AllowUserToResizeColumns = false;
            dtgPessoas.AllowUserToResizeRows = false;
            dtgPessoas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPessoas.Location = new Point(12, 135);
            dtgPessoas.Name = "dtgPessoas";
            dtgPessoas.RowHeadersVisible = false;
            dtgPessoas.RowHeadersWidth = 51;
            dtgPessoas.RowTemplate.Height = 29;
            dtgPessoas.Size = new Size(451, 337);
            dtgPessoas.TabIndex = 9;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(112, 79);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(94, 29);
            btnListar.TabIndex = 10;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 494);
            Controls.Add(btnListar);
            Controls.Add(dtgPessoas);
            Controls.Add(lblIdade);
            Controls.Add(btnLimpar);
            Controls.Add(btnRegistrar);
            Controls.Add(nudIdade);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Name = "FrmPrincipal";
            Text = "Principal";
            Load += FrmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)nudIdade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgPessoas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNome;
        private TextBox txtNome;
        private NumericUpDown nudIdade;
        private Button btnRegistrar;
        private Button btnLimpar;
        private Label lblIdade;
        private DataGridView dtgPessoas;
        private Button btnListar;
    }
}
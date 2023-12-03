namespace SimpleInject_Basic_SqlServer
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
            dtgPrincipal = new DataGridView();
            btnExecutar = new Button();
            txtConsulta = new TextBox();
            lblNome = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgPrincipal).BeginInit();
            SuspendLayout();
            // 
            // dtgPrincipal
            // 
            dtgPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPrincipal.Location = new Point(12, 100);
            dtgPrincipal.Name = "dtgPrincipal";
            dtgPrincipal.RowHeadersWidth = 51;
            dtgPrincipal.RowTemplate.Height = 29;
            dtgPrincipal.Size = new Size(760, 390);
            dtgPrincipal.TabIndex = 0;
            // 
            // btnExecutar
            // 
            btnExecutar.Location = new Point(617, 59);
            btnExecutar.Name = "btnExecutar";
            btnExecutar.Size = new Size(155, 28);
            btnExecutar.TabIndex = 1;
            btnExecutar.Text = "Executar";
            btnExecutar.UseVisualStyleBackColor = true;
            btnExecutar.Click += btnExecutar_Click;
            // 
            // txtConsulta
            // 
            txtConsulta.Location = new Point(12, 22);
            txtConsulta.Name = "txtConsulta";
            txtConsulta.Size = new Size(760, 27);
            txtConsulta.TabIndex = 5;
            // 
            // lblNome
            // 
            lblNome.Location = new Point(12, 52);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(89, 23);
            lblNome.TabIndex = 6;
            lblNome.Text = "new Query";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 502);
            Controls.Add(lblNome);
            Controls.Add(txtConsulta);
            Controls.Add(btnExecutar);
            Controls.Add(dtgPrincipal);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            Load += FrmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dtgPrincipal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgPrincipal;
        private Button btnExecutar;
        private TextBox txtConsulta;
        private Label lblNome;
    }
}
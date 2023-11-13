namespace API_BRY_ValidacaoAssinaturaDigital
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
            btnCarregarArquivo = new Button();
            SuspendLayout();
            // 
            // btnCarregarArquivo
            // 
            btnCarregarArquivo.Location = new Point(172, 261);
            btnCarregarArquivo.Name = "btnCarregarArquivo";
            btnCarregarArquivo.Size = new Size(158, 51);
            btnCarregarArquivo.TabIndex = 0;
            btnCarregarArquivo.Text = "Carregar Arquivo";
            btnCarregarArquivo.UseVisualStyleBackColor = true;
            btnCarregarArquivo.Click += btnCarregarArquivo_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 340);
            Controls.Add(btnCarregarArquivo);
            Name = "FrmPrincipal";
            Text = "Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCarregarArquivo;
    }
}
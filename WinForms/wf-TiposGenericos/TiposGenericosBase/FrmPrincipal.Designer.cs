namespace TiposGenericosBase
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
            btnMarca = new Button();
            btnCategoria = new Button();
            btnEmbalagem = new Button();
            SuspendLayout();
            // 
            // btnMarca
            // 
            btnMarca.Location = new Point(18, 59);
            btnMarca.Name = "btnMarca";
            btnMarca.Size = new Size(94, 29);
            btnMarca.TabIndex = 0;
            btnMarca.Text = "Marca";
            btnMarca.UseVisualStyleBackColor = true;
            btnMarca.Click += btnMarca_Click;
            // 
            // btnCategoria
            // 
            btnCategoria.Location = new Point(118, 59);
            btnCategoria.Name = "btnCategoria";
            btnCategoria.Size = new Size(94, 29);
            btnCategoria.TabIndex = 1;
            btnCategoria.Text = "Categoria";
            btnCategoria.UseVisualStyleBackColor = true;
            btnCategoria.Click += btnCategoria_Click;
            // 
            // btnEmbalagem
            // 
            btnEmbalagem.Location = new Point(218, 59);
            btnEmbalagem.Name = "btnEmbalagem";
            btnEmbalagem.Size = new Size(107, 29);
            btnEmbalagem.TabIndex = 2;
            btnEmbalagem.Text = "Embalagem";
            btnEmbalagem.UseVisualStyleBackColor = true;
            btnEmbalagem.Click += btnEmbalagem_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 100);
            Controls.Add(btnEmbalagem);
            Controls.Add(btnCategoria);
            Controls.Add(btnMarca);
            Name = "FrmPrincipal";
            Text = "Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMarca;
        private Button btnCategoria;
        private Button btnEmbalagem;
    }
}
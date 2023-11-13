namespace HerancaDeFormsComTiposGenericos
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
            lblTelasAberta = new Label();
            btnMini2 = new Button();
            btnMini1 = new Button();
            SuspendLayout();
            // 
            // lblTelasAberta
            // 
            lblTelasAberta.Location = new Point(29, 37);
            lblTelasAberta.Name = "lblTelasAberta";
            lblTelasAberta.Size = new Size(330, 25);
            lblTelasAberta.TabIndex = 5;
            lblTelasAberta.Text = "Abrir Formulários";
            lblTelasAberta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMini2
            // 
            btnMini2.Location = new Point(202, 92);
            btnMini2.Name = "btnMini2";
            btnMini2.Size = new Size(157, 53);
            btnMini2.TabIndex = 4;
            btnMini2.Text = "Mini 2";
            btnMini2.UseVisualStyleBackColor = true;
            btnMini2.Click += btnMini2_Click;
            // 
            // btnMini1
            // 
            btnMini1.Location = new Point(28, 92);
            btnMini1.Name = "btnMini1";
            btnMini1.Size = new Size(157, 53);
            btnMini1.TabIndex = 3;
            btnMini1.Text = "Mini 1";
            btnMini1.UseVisualStyleBackColor = true;
            btnMini1.Click += btnMini1_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 179);
            Controls.Add(lblTelasAberta);
            Controls.Add(btnMini2);
            Controls.Add(btnMini1);
            Name = "FrmPrincipal";
            Text = "Principal";
            ResumeLayout(false);
        }

        #endregion

        private Label lblTelasAberta;
        private Button btnMini2;
        private Button btnMini1;
    }
}
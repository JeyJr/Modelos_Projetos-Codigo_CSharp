namespace wf_ComboBox_basic
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
            cbo1 = new ComboBox();
            btnTeste = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // cbo1
            // 
            cbo1.FormattingEnabled = true;
            cbo1.Location = new Point(12, 41);
            cbo1.Name = "cbo1";
            cbo1.Size = new Size(371, 23);
            cbo1.TabIndex = 0;
            cbo1.TextChanged += cbo1_TextChanged;
            // 
            // btnTeste
            // 
            btnTeste.Location = new Point(283, 188);
            btnTeste.Name = "btnTeste";
            btnTeste.Size = new Size(75, 23);
            btnTeste.TabIndex = 1;
            btnTeste.Text = "Teste";
            btnTeste.UseVisualStyleBackColor = true;
            btnTeste.Click += btnTeste_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 64);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(371, 94);
            listBox1.TabIndex = 2;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(395, 336);
            Controls.Add(listBox1);
            Controls.Add(btnTeste);
            Controls.Add(cbo1);
            Name = "FrmPrincipal";
            Text = "Principal";
            Load += FrmPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbo1;
        private Button btnTeste;
        private ListBox listBox1;
    }
}
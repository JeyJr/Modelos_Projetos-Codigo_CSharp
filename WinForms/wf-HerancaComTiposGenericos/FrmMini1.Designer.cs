namespace HerancaDeFormsComTiposGenericos
{
    partial class FrmMini1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnFechar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(33, 52);
            label1.Name = "label1";
            label1.Size = new Size(212, 46);
            label1.TabIndex = 3;
            label1.Text = "Mini 1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(33, 123);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(212, 55);
            btnFechar.TabIndex = 2;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // FrmMini1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(279, 230);
            Controls.Add(label1);
            Controls.Add(btnFechar);
            Name = "FrmMini1";
            Text = "FrmMini1";
            FormClosed += FrmMini1_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnFechar;
    }
}
namespace wf_ComboBoxPersonalizado_AutoComplete_Com_ListView
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
            cboPersonalizado = new TableLayoutPanel();
            txtCboPersonalizado = new TextBox();
            btnCboPersonalizado = new Button();
            cboPersonalizado.SuspendLayout();
            SuspendLayout();
            // 
            // cboPersonalizado
            // 
            cboPersonalizado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cboPersonalizado.ColumnCount = 2;
            cboPersonalizado.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            cboPersonalizado.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            cboPersonalizado.Controls.Add(txtCboPersonalizado, 0, 0);
            cboPersonalizado.Controls.Add(btnCboPersonalizado, 1, 0);
            cboPersonalizado.Location = new Point(63, 38);
            cboPersonalizado.Margin = new Padding(0);
            cboPersonalizado.MinimumSize = new Size(0, 23);
            cboPersonalizado.Name = "cboPersonalizado";
            cboPersonalizado.RowCount = 1;
            cboPersonalizado.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            cboPersonalizado.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            cboPersonalizado.Size = new Size(280, 23);
            cboPersonalizado.TabIndex = 5;
            // 
            // txtCboPersonalizado
            // 
            txtCboPersonalizado.Dock = DockStyle.Fill;
            txtCboPersonalizado.Location = new Point(0, 0);
            txtCboPersonalizado.Margin = new Padding(0);
            txtCboPersonalizado.Name = "txtCboPersonalizado";
            txtCboPersonalizado.Size = new Size(257, 23);
            txtCboPersonalizado.TabIndex = 1;
            txtCboPersonalizado.TextChanged += txtCboPersonalizado_TextChanged;
            // 
            // btnCboPersonalizado
            // 
            btnCboPersonalizado.BackgroundImage = Properties.Resources.dropdownIcon;
            btnCboPersonalizado.BackgroundImageLayout = ImageLayout.Zoom;
            btnCboPersonalizado.FlatAppearance.BorderSize = 0;
            btnCboPersonalizado.FlatStyle = FlatStyle.Flat;
            btnCboPersonalizado.Location = new Point(257, 0);
            btnCboPersonalizado.Margin = new Padding(0);
            btnCboPersonalizado.Name = "btnCboPersonalizado";
            btnCboPersonalizado.Size = new Size(23, 22);
            btnCboPersonalizado.TabIndex = 0;
            btnCboPersonalizado.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(409, 357);
            Controls.Add(cboPersonalizado);
            Name = "FrmPrincipal";
            Text = "Principal";
            Load += FrmPrincipal_Load;
            cboPersonalizado.ResumeLayout(false);
            cboPersonalizado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel cboPersonalizado;
        private TextBox txtCboPersonalizado;
        private Button btnCboPersonalizado;
    }
}
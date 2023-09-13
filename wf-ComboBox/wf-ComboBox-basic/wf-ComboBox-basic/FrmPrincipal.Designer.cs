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
            comboBox1 = new ComboBox();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownHeight = 1;
            comboBox1.FormattingEnabled = true;
            comboBox1.IntegralHeight = false;
            comboBox1.Location = new Point(12, 41);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(371, 23);
            comboBox1.TabIndex = 0;
            comboBox1.TextChanged += comboBox1_TextChanged;
            comboBox1.KeyDown += comboBox1_KeyDown;
            comboBox1.Leave += comboBox1_Leave;
            // 
            // listView1
            // 
            listView1.Activation = ItemActivation.OneClick;
            listView1.HotTracking = true;
            listView1.HoverSelection = true;
            listView1.Location = new Point(12, 64);
            listView1.Name = "listView1";
            listView1.Size = new Size(371, 260);
            listView1.TabIndex = 2;
            listView1.TileSize = new Size(370, 15);
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Tile;
            listView1.Visible = false;
            listView1.Click += listView1_Click;
            listView1.KeyDown += listView1_KeyDown;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(395, 336);
            Controls.Add(listView1);
            Controls.Add(comboBox1);
            Name = "FrmPrincipal";
            Text = "Principal";
            Load += FrmPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private ListView listView1;
    }
}
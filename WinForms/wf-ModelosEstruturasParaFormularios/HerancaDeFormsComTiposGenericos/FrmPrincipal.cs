namespace HerancaDeFormsComTiposGenericos
{
    public partial class FrmPrincipal : Tela_Base.FrmGestor
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        protected override void AbrirFilho<T>()
        {
            base.AbrirFilho<T>();
        }

        private void btnMini1_Click(object sender, EventArgs e)
        {
            AbrirFilho<FrmMini1>();
        }

        private void btnMini2_Click(object sender, EventArgs e)
        {
            AbrirFilho<FrmMini2>();
        }
    }
}
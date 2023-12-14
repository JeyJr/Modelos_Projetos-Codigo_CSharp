namespace NavigationPageExemplo;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}

    private void Page2_Loaded(object sender, EventArgs e)
    {
		
    }

    private void btnVoltar_Clicked(object sender, EventArgs e)
    {
        this.Navigation.PopAsync(true);
    }
}
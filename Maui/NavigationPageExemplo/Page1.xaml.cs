namespace NavigationPageExemplo;

public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
	}

    private void btnAnterior_Clicked(object sender, EventArgs e)
    {
        this.Navigation.PopAsync(true);
    }

    private void btnProximo_Clicked(object sender, EventArgs e)
    {
        this.Navigation.PushAsync(new Page2(), true);
    }
}
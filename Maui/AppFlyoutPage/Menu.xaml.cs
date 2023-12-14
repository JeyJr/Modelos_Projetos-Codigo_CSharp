namespace AppFlyoutPage;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
	}

    private void btnPg1_Clicked(object sender, EventArgs e)
    {
        if (App.Current.MainPage is FlyoutPage flyout && flyout != null)
        {
            flyout.Detail = new Page1();
        }
    }

    private void btnPg2_Clicked(object sender, EventArgs e)
    {
        if(App.Current.MainPage is FlyoutPage flyout && flyout != null)
        {
            flyout.Detail = new Page2();
        }
    }

    private void btnPg3_Clicked(object sender, EventArgs e)
    {
        if (App.Current.MainPage is FlyoutPage flyout && flyout != null)
        {
            flyout.Detail = new Page3();
        }
    }
}
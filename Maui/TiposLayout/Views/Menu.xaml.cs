

namespace TiposLayout.Views;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
	}

    #region Eventos
    private void ContentPage_Loaded(object sender, EventArgs e)
    {

    }

    private void lblStackLayout_Tapped(object sender, TappedEventArgs e)
    {
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new TiposLayout.Views.StackLayoutPage());
        ((FlyoutPage)App.Current.MainPage).IsPresented = false;
    }

    private void lblGridLayout_Tapped(object sender, TappedEventArgs e)
    {
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new TiposLayout.Views.GridLayoutPage());
        ((FlyoutPage)App.Current.MainPage).IsPresented = false;
    }

    private void lblAbsoluteLayout_Tapped(object sender, TappedEventArgs e)
    {
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new TiposLayout.Views.AbsoluteLayoutPage());
        ((FlyoutPage)App.Current.MainPage).IsPresented = false;
    }

    private void lblFlexLayout_Tapped(object sender, TappedEventArgs e)
    {
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new TiposLayout.Views.FlexLayoutPage());
        ((FlyoutPage)App.Current.MainPage).IsPresented = false;
    }
    #endregion

    #region Metodos
    #endregion
}
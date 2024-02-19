using TiposLayout.Controls;

namespace TiposLayout.Views;

public partial class AbsoluteLayoutPage : ContentPage
{
	public AbsoluteLayoutPage()
	{
		InitializeComponent();
        NavigationPage.SetTitleView(this, CustomComponentsControl.GetCustomTitle("Absolute Layout Page", 12));
    }
}
using TiposLayout.Controls;

namespace TiposLayout.Views;

public partial class GridLayoutPage : ContentPage
{
	public GridLayoutPage()
	{
		InitializeComponent();
        NavigationPage.SetTitleView(this, CustomComponentsControl.GetCustomTitle("Grid Layout Page", 12));
    }
}
using TiposLayout.Controls;

namespace TiposLayout.Views;

public partial class FlexLayoutPage : ContentPage
{
	public FlexLayoutPage()
	{
		InitializeComponent();
        NavigationPage.SetTitleView(this, CustomComponentsControl.GetCustomTitle("Flex Layout Page", 12));
    }
}
using TiposLayout.Controls;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
namespace TiposLayout.Views;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class StackLayoutPage : ContentPage
{
	public StackLayoutPage()
	{
		InitializeComponent();
        NavigationPage.SetTitleView(this, CustomComponentsControl.GetCustomTitle("Stack Laytout Page", 12));
    }
}
using AppGallery.Models;
using AppGallery.Repositories;

namespace AppGallery.Views;

public partial class Menu : ContentPage
{
	private CategoryRepository categoryRepository;
	
    public Menu()
	{
		InitializeComponent();
		categoryRepository = new CategoryRepository();
	}

	#region Eventos
	private void ContentPage_Loaded(object sender, EventArgs e)
    {
		CarregarLabels();
    }
	#endregion

	#region Metodos
	private void CarregarLabels()
	{
		try
		{
			if (categoryRepository == null)
				throw new Exception("Falha ao carregar categorias");

			var categoriaCollection = categoryRepository.GetCategories();

			if(categoriaCollection ==  null || categoriaCollection.Count <= 0)
                throw new Exception("Nenhuma categoria encontrada");

			foreach (var categoria in categoriaCollection)
			{
				//Título do agrupamento
				var lblCategoria = new Label() 
				{ 
					Text = categoria.Name,
					FontFamily = "Roboto-Bold",
					FontSize = 18,
				};

				MenuContainer.Children.Add(lblCategoria);



				foreach (var componente in categoria.Components)
				{
					var lblComponenteTitle = new Label() 
					{ 
						Text = componente.Title, 
						FontFamily = "OpenSansSemibold", 
						FontSize = 15,
						Margin = new Thickness(15, 15, 15, 5) 
					};

					var lblComponenteDescription = new Label() 
					{ 
						Text = componente.Description, 
						FontFamily = "OpenSansRegular",
						FontSize = 11,
						Margin = new Thickness(15, 0, 15, 25) 
					};

                    MenuContainer.Children.Add(lblComponenteTitle);
                    MenuContainer.Children.Add(lblComponenteDescription);
                }
            }

        }
        catch (Exception ex)
		{
			DisplayAlert("Error", ex.Message, "Cancelar");
		}
	}
    #endregion

    private void lblInicio_Tapped(object sender, TappedEventArgs e)
    {
		((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new AppGallery.Views.MainPage());
        ((FlyoutPage)App.Current.MainPage).IsPresented = false;
    }
}
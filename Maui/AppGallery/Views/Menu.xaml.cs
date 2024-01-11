using AppGallery.Models;
using AppGallery.Repositories;
using AppGallery.Views.Layouts;

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


					var tap = new TapGestureRecognizer();
					/* Passar um objeto no tap */
					tap.CommandParameter = componente.Page;
					tap.Tapped += labelsCategoria_Tapped;


					lblComponenteTitle.GestureRecognizers.Add(tap);
					lblComponenteDescription.GestureRecognizers.Add(tap);

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

	private void labelsCategoria_Tapped(object sender, TappedEventArgs e)
	{
		var label = (Label)sender;

		if (label == null)
			throw new Exception("Falha ao carregar interface!");

		var tap = (TapGestureRecognizer)label.GestureRecognizers[0];
		var page = (Type)tap.CommandParameter;

        /* Sem flyoutpage abre a tela mas não teremos mais o menu lateral */
        //App.Current.MainPage = page;

        /* 
		Nesse modelo as paginas eram instanciadas todas na inicialização do projeto e exibidas quando fossem chamadas (instanciadas no CategoryRepository) 
		Isso gera uma grande perda de memoria, 
		a outra solução seria não instanciar as telas na inicialização e sim, quando forem chamadas no click igual exemplo abaixo
		*/
        //((FlyoutPage)App.Current.MainPage).Detail = page;
        //((FlyoutPage)App.Current.MainPage).IsPresented = false;

        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage((Page)Activator.CreateInstance(page));
        ((FlyoutPage)App.Current.MainPage).IsPresented = false;

    }

    private void lblInicio_Tapped(object sender, TappedEventArgs e)
    {
		((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new AppGallery.Views.MainPage());
        ((FlyoutPage)App.Current.MainPage).IsPresented = false;
    }
}
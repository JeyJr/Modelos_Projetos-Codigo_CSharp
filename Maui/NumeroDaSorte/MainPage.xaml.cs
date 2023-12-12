namespace NumeroDaSorte;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    #region Eventos
    private void mainLayout_Loaded(object sender, EventArgs e)
    {
        nameApp.IsVisible = false;
        SetLayoutState();
    }
    private void btnDrawNumbers_Clicked(object sender, EventArgs e)
    {
        SetLayoutState();
    }
    #endregion

    #region Metodos
    private void SetLayoutState()
    {
        nameApp.IsVisible = !nameApp.IsVisible;
        containerLuckNumbers.IsVisible = !nameApp.IsVisible;
       
        btnDrawNumbers.Text = "Gerar número da sorte!";

        if (containerLuckNumbers.IsVisible)
        {
            OnGenerateLuckNumbers();
            btnDrawNumbers.Text = "Reiniciar!";
        }
    }
	private void OnGenerateLuckNumbers()
	{
        var numbers = new int[6];
        Random r = new Random();
        int totalNumbersDrawn = 0;

        while (totalNumbersDrawn < numbers.Length)
        {
            int n = r.Next(1, 61);

            if(!numbers.Contains(n))
            {
                numbers[totalNumbersDrawn] = n;
                totalNumbersDrawn++;
            }
        }

        luckNumber01.Text = numbers[0] <= 9 ? $"0{numbers[0]}" : numbers[0].ToString();
        luckNumber02.Text = numbers[1] <= 9 ? $"0{numbers[1]}" : numbers[1].ToString();
        luckNumber03.Text = numbers[2] <= 9 ? $"0{numbers[2]}" : numbers[2].ToString();
        luckNumber04.Text = numbers[3] <= 9 ? $"0{numbers[3]}" : numbers[3].ToString();
        luckNumber05.Text = numbers[4] <= 9 ? $"0{numbers[4]}" : numbers[4].ToString();
        luckNumber06.Text = numbers[5] <= 9 ? $"0{numbers[5]}" : numbers[5].ToString();
    }
    #endregion

}
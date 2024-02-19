using Microsoft.Maui.Controls;

namespace TiposLayout.Controls
{
    public static class CustomComponentsControl
    {
        public static View GetCustomTitle(string title, float size)
        {
            //var stackLayout = new StackLayout
            //{
            //    Orientation = StackOrientation.Horizontal,
            //    HorizontalOptions = LayoutOptions.Fill,
            //    VerticalOptions = LayoutOptions.Center
            //};

            //var btnExample = new Button()
            //{
            //    Text = "Exemplo de Botão",
            //    FontSize = size,
            //    FontFamily = "OpenSansRegular",
            //    TextColor = Color.FromRgba(1, 1, 1, 1),
            //    BackgroundColor = Color.FromRgba(0, 1, 0, 1),
            //    HorizontalOptions = LayoutOptions.Start
            //};

            var lblTitle = new Label()
            {
                Text = title,
                FontSize = size,
                FontFamily = "OpenSansRegular",
                TextColor = Color.FromArgb("000000"),
                FontAttributes = FontAttributes.None,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                BackgroundColor = Color.FromArgb("8AE28A"),
                HorizontalOptions = LayoutOptions.End,
            };


            //stackLayout.Children.Add(lblTitle);
            //stackLayout.Children.Add(btnExample);

            return lblTitle;
        }
    }
}

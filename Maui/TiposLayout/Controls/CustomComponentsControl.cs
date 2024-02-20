using Microsoft.Maui.Controls;
using System.Runtime.CompilerServices;

namespace TiposLayout.Controls
{
    public static class CustomComponentsControl
    {
        public static View GetCustomTitle(string title, float size, double translateX = 15)
        {
            var lblTitle = new Label()
            {
                Text = title,
                FontSize = size,
                FontFamily = "OpenSansRegular",
                TextColor = Color.FromArgb("8AE28A"),
                FontAttributes = FontAttributes.None,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                TranslationX = translateX,
                HorizontalOptions = LayoutOptions.End,
            };
            return lblTitle;
        }
    }
}

using Infrastructure.Base;
using System.Windows.Media;

namespace BasicControls.Label
{
    internal class LabelProperties : PropertyChangedBase
    {
        private string content;
        public string Content
        {
            get => content;
            set => SetField(ref content, value);
        }

        private FontFamily fontFamily;
        public FontFamily FontFamily
        {
            get => fontFamily;
            set => SetField(ref fontFamily, value);
        }

        private double fontSize;
        public double FontSize
        {
            get => fontSize;
            set => SetField(ref fontSize, value);
        }

        private System.Windows.FontWeight fontWeight;
        public System.Windows.FontWeight FontWeight
        {
            get => fontWeight;
            set => SetField(ref fontWeight, value);
        }

        private string foreground;
        public string Foreground
        {
            get => foreground;
            set => SetField(ref foreground, value);
        }

        private string background;
        public string Background
        {
            get => background;
            set => SetField(ref background, value);
        }

        private string horizontalAlignment;
        public string HorizontalAlignment
        {
            get => horizontalAlignment;
            set => SetField(ref horizontalAlignment, value);
        }

        private string verticalAlignment;
        public string VerticalAlignment
        {
            get => verticalAlignment;
            set => SetField(ref verticalAlignment, value);
        }

        private int width;
        public int Width
        {
            get => width;
            set => SetField(ref width, value);
        }

        private int height;

        public int Height
        {
            get => height;
            set => SetField(ref height, value);
        }

        private Brush borderBrush;
        public Brush BorderBrush 
        {
            get => borderBrush; 
            set => SetField(ref borderBrush , value); 
        }

        private int borderThickness;
        public int BorderThickness
        {
            get => borderThickness;
            set => SetField(ref borderThickness, value);
        }

        public LabelProperties(string content, FontFamily fontFamily, double fontSize, System.Windows.FontWeight fontWeight, string foreground, string background, string horizontalAlignment, string verticalAlignment, int width, int height, Brush borderBrush, int borderThickness)
        {
            Content = content;
            FontFamily = fontFamily;
            FontSize = fontSize;
            FontWeight = fontWeight;
            Foreground = foreground;
            Background = background;
            HorizontalAlignment = horizontalAlignment;
            VerticalAlignment = verticalAlignment;
            Width = width;
            Height = height;
            BorderBrush = borderBrush;
            BorderThickness = borderThickness;
        }
    }
}

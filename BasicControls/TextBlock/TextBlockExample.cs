using Infrastructure.Base;
using System.Windows.Media;

namespace BasicControls.TextBlock
{
    internal class TextBlockExample : PropertyChangedBase
    {
        private string text;
        public string Text
        {
            get => text;
            set => SetField(ref text, value);
        }
        private double fontSize;
        public double FontSize
        {
            get => fontSize;
            set => SetField(ref fontSize, value);
        }

        private FontFamily fontFamily;
        public FontFamily FontFamily
        {
            get => fontFamily;
            set => SetField(ref fontFamily, value);
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
    }
}

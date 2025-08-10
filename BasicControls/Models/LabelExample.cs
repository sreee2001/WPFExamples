namespace BasicControls.Models
{
    internal class LabelExample
    {
        public string Content { get; set; }
        public string FontFamily { get; set; }
        public double FontSize { get; set; }
        public string FontWeight { get; set; }
        public string Foreground { get; set; }
        public string Background { get; set; }
        public string HorizontalAlignment { get; set; }
        public string VerticalAlignment { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public LabelExample(string content, string fontFamily, double fontSize, string fontWeight, string foreground, string background, string horizontalAlignment, string verticalAlignment, int width, int height)
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
        }
    }
}

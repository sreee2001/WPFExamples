namespace BasicControls.Models
{
    internal class LabelExample
    {
        public string Text { get; set; }
        public string FontFamily { get; set; }
        public double FontSize { get; set; }
        public bool IsBold { get; set; }
        public bool IsItalic { get; set; }
        public bool IsUnderline { get; set; }
        public bool IsStrikethrough { get; set; }
        public LabelExample(string text, string fontFamily, double fontSize, bool isBold, bool isItalic, bool isUnderline, bool isStrikethrough)
        {
            Text = text;
            FontFamily = fontFamily;
            FontSize = fontSize;
            IsBold = isBold;
            IsItalic = isItalic;
            IsUnderline = isUnderline;
            IsStrikethrough = isStrikethrough;
        }
    }
}

using Infrastructure.Base;
using System.Windows;
using System.Windows.Media;

namespace BasicControls.TextBlock
{
    /// <summary>
    /// Represents a collection of properties for configuring the appearance and layout of a text block.
    /// </summary>
    /// <remarks>This class provides properties to control the text content, font characteristics, alignment,
    /// and  other visual aspects of a text block. It is designed to support data binding and property change 
    /// notifications, making it suitable for use in dynamic UI scenarios.</remarks>
    internal class TextBlockProperties : PropertyChangedBase
    {
        private string text;
        /// <summary>
        /// The text content to display.
        /// </summary>
        public string Text
        {
            get => text;
            set => SetField(ref text, value);
        }

        private FontWeight fontWeight;
        /// <summary>
        /// The weight (boldness) of the text.
        /// </summary>
        public FontWeight FontWeight
        {
            get => fontWeight;
            set => SetField(ref fontWeight, value);
        }

        private FontStyle fontStyle;
        /// <summary>
        /// The style (italic, normal) of the text.
        /// </summary>
        public FontStyle FontStyle
        {
            get => fontStyle;
            set => SetField(ref fontStyle, value);
        }

        private FontStretch fontStretch;
        /// <summary>
        /// The stretch of the font face.
        /// </summary>
        public FontStretch FontStretch
        {
            get => fontStretch;
            set => SetField(ref fontStretch, value);
        }

        private double fontSize;
        /// <summary>
        /// The size of the text.
        /// </summary>
        public double FontSize
        {
            get => fontSize;
            set => SetField(ref fontSize, value);
        }

        private FontFamily fontFamily;
        /// <summary>
        /// The font family of the text.
        /// </summary>
        public FontFamily FontFamily
        {
            get => fontFamily;
            set => SetField(ref fontFamily, value);
        }

        private string foreground;
        /// <summary>
        /// The brush used to paint the text.
        /// </summary>
        public string Foreground
        {
            get => foreground;
            set => SetField(ref foreground, value);
        }

        private string background;
        /// <summary>
        /// The background brush (not rendered by default).
        /// </summary>
        public string Background
        {
            get => background;
            set => SetField(ref background, value);
        }

        private string horizontalAlignment;
        /// <summary>
        /// Horizontal alignment in the parent container.
        /// </summary>
        public string HorizontalAlignment
        {
            get => horizontalAlignment;
            set => SetField(ref horizontalAlignment, value);
        }

        private string verticalAlignment;
        /// <summary>
        /// Vertical alignment in the parent container.
        /// </summary>
        public string VerticalAlignment
        {
            get => verticalAlignment;
            set => SetField(ref verticalAlignment, value);
        }
    }
}

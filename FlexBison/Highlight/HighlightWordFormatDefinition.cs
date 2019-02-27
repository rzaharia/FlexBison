using System.ComponentModel.Composition;
using System.Windows.Media;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace FlexBison
{
    [Export(typeof(EditorFormatDefinition))]
    [Name("MakerFormatDefinition/HighlightWordFormatDefinition")]
    [UserVisible(true)]
    public class HighlightWordFormatDefinition : MarkerFormatDefinition
    {
        public HighlightWordFormatDefinition()
        {
            this.BackgroundColor = Colors.LightBlue;
            this.ForegroundColor = Colors.DarkBlue;
            this.DisplayName = "Highlight word";
            this.ZOrder = 5;
        }
    }
}
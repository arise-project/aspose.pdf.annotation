using Aspose.Pdf;
using aspose.pdf.annotation.Model.Descriptions;

namespace aspose.pdf.annotation.Model;

public class WatermarkModel
{
    public PagePositionModel Position { get; set; }

    public string[] Text { get; set; }

    public double Opacity { get; set; }

    public Color ForegroundColor { get; set; }
    
    public string Font { get; set; }

    public int FontSize { get; set; }
}
using Aspose.Pdf;
using aspose.pdf.annotation.Model.Descriptions;

namespace aspose.pdf.annotation.Model;

public class RedactModel
{
    public PagePositionModel Position { get; set; } = new PagePositionModel();

    public Color FillColor { get; set; } = Color.Aqua;
    
    public Color BorderColor { get;set; } = Color.Black;

    public Color Color { get; set; } = Color.Beige;

    public string OverlayText { get; set; } = "CENSORED";
    
    public HorizontalAlignment TextAlignment { get;set; } = HorizontalAlignment.Center;

    public bool Repeat { get; set; } = true;
}
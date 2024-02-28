using Aspose.Pdf;
using aspose.pdf.annotation.Model.Descriptions;

namespace aspose.pdf.annotation.Model;

public class RedactModel
{
    public PagePositionModel Position { get; set; }

    public Color FillColor { get;set; }
    
    public Color BorderColor { get;set; }
    
    public Color Color { get;set; }
    
    public string OverlayText { get;set; }
    
    public HorizontalAlignment TextAlignment { get;set; }
    
    public bool Repeat { get;set; }
}
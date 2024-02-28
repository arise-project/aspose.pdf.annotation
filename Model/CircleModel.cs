using Aspose.Pdf;
using aspose.pdf.annotation.Model.Descriptions;

namespace aspose.pdf.annotation.Model;

public class CircleModel
{
    public PagePositionModel Position { get; set; }
    
    public TitleModel Title { get; set; }

    public Color InteriorColor { get; set; }
    
    public PagePositionModel Popup { get; set; }
}
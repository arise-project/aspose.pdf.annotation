using Aspose.Pdf;
using aspose.pdf.annotation.Model.Descriptions;

namespace aspose.pdf.annotation.Model;

public class SquareModel
{
    public PagePositionModel Position { get; set; } = new PagePositionModel();
    
    public TitleModel Title { get; set; } = new TitleModel();
    
    public PagePositionModel Popup { get; set; } = new PagePositionModel();

    public Color InteriorColor { get; set; } = Color.Aqua;
}
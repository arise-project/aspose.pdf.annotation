using aspose.pdf.annotation.Model.Descriptions;

namespace aspose.pdf.annotation.Model;

public class PolygonModel
{
    public PagePositionModel Position { get; set; }
    
    public TitleModel Title { get; set; }
    
    public PagePositionModel Popup { get; set; }
    
    public PointModel[] Points { get; set; }
}
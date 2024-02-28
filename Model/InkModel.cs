using aspose.pdf.annotation.Model.Descriptions;

namespace aspose.pdf.annotation.Model;

public class InkModel
{
    public PagePositionModel Position { get; set; }
    
    public TitleModel Title { get; set; }

    public PointModel[] Points { get; set; }
    
    public int Border { get; set; }
}
using aspose.pdf.annotation.Model.Descriptions;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation.Model;

public class InkModel
{
    public PagePositionModel Position { get; set; }
    
    public TitleModel Title { get; set; }

    public PointModel[] Points { get; set; }
    
    public int Border { get; set; }
    
    public CapStyle CapStyle { get; set; }
}
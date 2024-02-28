using aspose.pdf.annotation.Model.Descriptions;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation.Model;

public class InkModel
{
    public PagePositionModel Position { get; set; } = new PagePositionModel();
    
    public TitleModel Title { get; set; } = new TitleModel();

    public PointModel[] Points { get; set; } = new PointModel[] { new PointModel { X = 10, Y = 10 }, new PointModel { X = 20, Y = 20 } };

    public int Border { get; set; } = 5;

    public CapStyle CapStyle { get; set; } = CapStyle.Rounded;
}
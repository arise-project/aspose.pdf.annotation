using System.Net.NetworkInformation;
using aspose.pdf.annotation.Model.Descriptions;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation.Model;

public class LineModel
{
    public PagePositionModel Position { get; set; } = new PagePositionModel();
    
    public TitleModel Title { get; set; } = new TitleModel();

    public PointModel Start { get; set; } = new PointModel { X = 10, Y = 10 };

    public PointModel End { get; set; } = new PointModel { X = 20, Y = 20 };

    public PagePositionModel Popup { get; set; } = new PagePositionModel();

    public int Width { get; set; } = 50;

    public LineEnding StartingStyle { get; set; } = LineEnding.Circle;

    public LineEnding EndingStyle { get; set; } = LineEnding.ClosedArrow;
}
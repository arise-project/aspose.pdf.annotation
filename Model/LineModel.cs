using System.Net.NetworkInformation;
using aspose.pdf.annotation.Model.Descriptions;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation.Model;

public class LineModel
{
    public PagePositionModel Position { get; set; }
    
    public TitleModel Title { get; set; }

    public PointModel Start { get; set; }

    public PointModel End { get; set; }

    public PagePositionModel Popup { get; set; }

    public int Width { get; set; }
    
    public LineEnding StartingStyle { get; set; }
    
    public LineEnding EndingStyle { get; set; }
}
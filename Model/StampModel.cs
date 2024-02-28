using Aspose.Pdf;
using aspose.pdf.annotation.Model.Descriptions;

namespace aspose.pdf.annotation.Model;

public class StampModel
{
    public PagePositionModel Page { get; set; }

    public string ImageFile { get; set; }

    public bool Background { get; set; }
    
    public int XIndent { get; set; }
    
    public int YIndent { get; set; }
    
    public int Height { get; set; }
    
    public int Width { get; set; }
    
    public Rotation Rotate { get; set; }
    
    public double Opacity { get; set; }
}
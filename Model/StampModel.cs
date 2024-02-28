using Aspose.Pdf;
using aspose.pdf.annotation.Model.Descriptions;

namespace aspose.pdf.annotation.Model;

public class StampModel
{
    public PageModel Page { get; set; } = new PageModel();

    public string ImageFile { get; set; } = "test.bmp";

    public bool Background { get; set; } = true;

    public int XIndent { get; set; } = 10;

    public int YIndent { get; set; } = 10;

    public int Height { get; set; } = 50;

    public int Width { get; set; } = 50;

    public Rotation Rotate { get; set; } = Rotation.on90;

    public double Opacity { get; set; } = 0.5;
}
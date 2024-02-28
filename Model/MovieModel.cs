using aspose.pdf.annotation.Model.Descriptions;

namespace aspose.pdf.annotation.Model;

public class MovieModel
{
    public PagePositionModel Position { get; set; } = new PagePositionModel();

    public string MediaFile { get; set; } = "test.avi";
}
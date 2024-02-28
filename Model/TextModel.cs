using aspose.pdf.annotation.Model.Descriptions;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation.Model;

public class TextModel
{
    public PagePositionModel Position { get; set; } = new PagePositionModel();
    
    public TitleModel Title { get; set; } = new TitleModel();

    public string Contents { get; set; } = "test";

    public bool Open { get; set; } = true;

    public TextIcon Icon { get; set; } = TextIcon.Comment;

    public int Border { get; set; } = 5;
}
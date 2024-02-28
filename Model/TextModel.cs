using aspose.pdf.annotation.Model.Descriptions;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation.Model;

public class TextModel
{
    public PagePositionModel Position { get; set; }
    
    public TitleModel Title { get; set; }
    
    public string Contents { get; set; }
    
    public bool Open { get; set; }
    
    public TextIcon Icon { get; set; }

    public int Border { get; set; }
}
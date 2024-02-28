using Aspose.Pdf;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation.Model;

public class CaretModel
{
    public PagePositionModel Position { get; set; }
    
    public string Title { get; set; }
    
    public string  Subject { get; set; }
    
    public AnnotationFlags Flags { get; set; }
    
    public Color Color { get; set; }
}
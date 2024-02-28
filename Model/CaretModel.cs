using aspose.pdf.annotation.Model.Descriptions;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation.Model;

public class CaretModel
{
    public PagePositionModel Position { get; set; } = new PagePositionModel();

    public TitleModel Title { get; set; } = new TitleModel();

    public AnnotationFlags Flags { get; set; } = AnnotationFlags.Default;
}
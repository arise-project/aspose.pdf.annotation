using Aspose.Pdf;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation;

public class CaretAnnotator : IAnnotator
{
    public void Add()
    {
        // Load the PDF file
        Document document = new Document(System.IO.Path.Combine("./example", "sample.pdf"));
        // This annotation is used to indicate the insertion of text
        var caretAnnotation1 = new CaretAnnotation(document.Pages[1], new Rectangle(299.988, 713.664, 308.708, 720.769))
        {
            Title = "Aspose User",
            Subject = "Inserted text 1",
            Flags = AnnotationFlags.Print,
            Color = Color.Blue
        };
        // This annotation is used to indicate the replacement of text
        var caretAnnotation2 = new CaretAnnotation(document.Pages[1], new Rectangle(361.246, 727.908, 370.081, 735.107))
        {
            Flags = AnnotationFlags.Print,
            Subject = "Inserted text 2",
            Title = "Aspose User",
            Color = Color.Blue
        };

        var strikeOutAnnotation = new StrikeOutAnnotation(document.Pages[1],
            new Rectangle(318.407, 727.826, 368.916, 740.098))
        {
            Color = Color.Blue,
            QuadPoints = new[] {
                new Point(321.66, 739.416),
                new Point(365.664, 739.416),
                new Point(321.66, 728.508),
                new Point(365.664, 728.508)
            },
            Subject = "Cross-out",
            InReplyTo = caretAnnotation2,
            ReplyType = ReplyType.Group
        };

        document.Pages[1].Annotations.Add(caretAnnotation1);
        document.Pages[1].Annotations.Add(caretAnnotation2);
        document.Pages[1].Annotations.Add(strikeOutAnnotation);

        document.Save(System.IO.Path.Combine("./example", "sample_caret.pdf"));
    }
}
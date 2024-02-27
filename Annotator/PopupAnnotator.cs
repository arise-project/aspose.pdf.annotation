using Aspose.Pdf;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation;

public class PopupAnnotator : IAnnotator
{
    public void Add()
    {
        // Load the PDF file
        Document document = new Document(System.IO.Path.Combine("./examples", "Appartments.pdf"));

        // Create Line Annotation
        var lineAnnotation = new LineAnnotation(
            document.Pages[1],
            new Rectangle(550, 93, 562, 439),
            new Point(556, 99), new Point(556, 443))
        {
            Title = "John Smith",
            Color = Color.Red,
            Width = 3,
            StartingStyle = LineEnding.OpenArrow,
            EndingStyle = LineEnding.OpenArrow,
            Popup = new PopupAnnotation(document.Pages[1], new Rectangle(842, 124, 1021, 266))
        };

        // Add annotation to the page
        document.Pages[1].Annotations.Add(lineAnnotation);
        document.Save(System.IO.Path.Combine("./examples", "Appartments_mod.pdf"));
    }
}
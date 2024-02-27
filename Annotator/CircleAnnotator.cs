using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation;

public class CircleAnnotator : IAnnotator
{
    private readonly CircleModel _model;

    public CircleAnnotator(CircleModel model)
    {
        _model = model;
    }

    public void Add()
    {
        var dataDir = "<path-to-file>";
        // Load the PDF file
        Document document = new Document(System.IO.Path.Combine(dataDir, "appartments.pdf"));

        // Create Cirlce Annotation
        var circleAnnotation = new CircleAnnotation(document.Pages[1], new Rectangle(270, 160, 483, 383))
        {
            Title = "John Smith",
            Subject = "Circle",
            Color = Color.Red,
            InteriorColor = Color.MistyRose,
            Opacity = 0.5,        
            Popup = new PopupAnnotation(document.Pages[1], new Rectangle(842, 316, 1021, 459))
        };

        // Add annotation to the page
        document.Pages[1].Annotations.Add(circleAnnotation);
        document.Save(System.IO.Path.Combine(dataDir, "appartments_mod.pdf"));
    }
}
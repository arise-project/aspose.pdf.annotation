using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation;

public class PolyLineAnnotator : IAnnotator
{
    private readonly PolyLineModel _model;
    private readonly string _workFolder;

    public PolyLineAnnotator(PolyLineModel model, string workFolder)
    {
        _model = model;
        _workFolder = workFolder;
    }

    public void Add()
    {
        // Load the PDF file
        Document document = new Document(System.IO.Path.Combine(_workFolder, "appartments.pdf"));

        // Create Polygon Annotation
        var polygonAnnotation = new PolygonAnnotation(document.Pages[1],
            new Rectangle(270, 193, 571, 383),
            new Point[] {
                new Point(274, 381),
                new Point(555, 381),
                new Point(555, 304),
                new Point(570, 304),
                new Point(570, 195),
                new Point(274, 195)})
        {
            Title = "John Smith",
            Color = Color.Blue,
            InteriorColor = Color.BlueViolet,
            Opacity = 0.25,
            Popup = new PopupAnnotation(document.Pages[1], new Rectangle(842, 196, 1021, 338))
        };

        // Create PoliLine Annotation
        var polylineAnnotation = new PolylineAnnotation(document.Pages[1],
            new Rectangle(270, 193, 571, 383),
            new Point[] {
                new Point(545,150),
                new Point(545,190),
                new Point(667,190),
                new Point(667,110),
                new Point(626,111)
            })
        {
            Title = "John Smith",
            Color = Color.Red,
            Popup = new PopupAnnotation(document.Pages[1], new Rectangle(842, 196, 1021, 338))
        };

        // Add annotation to the page
        document.Pages[1].Annotations.Add(polygonAnnotation);
        document.Pages[1].Annotations.Add(polylineAnnotation);
        document.Save(System.IO.Path.Combine(_workFolder, "appartments_mod.pdf"));
    }
}
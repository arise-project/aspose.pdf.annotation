using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation;

public class PolygonAnnotator : IAnnotator
{
    private readonly PolygonModel _model;
    private readonly string _workFolder;
    private readonly string _inputFile;
    private readonly string _outputFile;

    public PolygonAnnotator(PolygonModel model, string workFolder, string inputFile, string outputFile)
    {
        _model = model;
        _workFolder = workFolder;
        _inputFile = inputFile;
        _outputFile = outputFile;
    }

    public void Add()
    {
        // Load the PDF file
        Document document = new Document(Path.Combine(_workFolder, _inputFile));

        // Create Polygon Annotation
        var polygonAnnotation = new PolygonAnnotation(
            document.Pages[_model.Position.PageNumber], 
            new Rectangle(
                _model.Position.Llx, 
                _model.Position.Lly, 
                _model.Position.Urx,
                _model.Position.Ury),
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
        document.Save(Path.Combine(_workFolder, _outputFile));
    }
}
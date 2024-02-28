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
                _model.Position.Ury,
                _model.Position.NormalizeCoordinates),
            new Point[] {
                new Point(274, 381),
                new Point(555, 381),
                new Point(555, 304),
                new Point(570, 304),
                new Point(570, 195),
                new Point(274, 195)})
        {
            Title = _model.Title.Title,
            Subject = _model.Title.Subject,
            Color = _model.Title.Color,
            Opacity = _model.Title.Opacity,
            InteriorColor = Color.BlueViolet,
            Popup = new PopupAnnotation(
                document.Pages[_model.Popup.PageNumber], 
                new Rectangle(
                    _model.Popup.Llx, 
                    _model.Popup.Lly, 
                    _model.Popup.Urx,
                    _model.Popup.Ury,
                    _model.Popup.NormalizeCoordinates))
        };

        // Add annotation to the page
        document
            .Pages[_model.Position.PageNumber]
            .Annotations
            .Add(polygonAnnotation);
        
        document.Save(Path.Combine(_workFolder, _outputFile));
    }
}
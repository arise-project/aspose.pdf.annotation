using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation;

public class PolyLineAnnotator : IAnnotator
{
    private readonly PolyLineModel _model;
    private readonly string _workFolder;
    private readonly string _inputFile;
    private readonly string _outputFile;

    public PolyLineAnnotator(PolyLineModel model, string workFolder, string inputFile, string outputFile)
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
            Title = _model.Title.Title,
            Subject = _model.Title.Subject,
            Color = _model.Title.Color,
            Popup = new PopupAnnotation(
                document.Pages[_model.Position.PageNumber], 
                new Rectangle(842, 196, 1021, 338))
        };

        // Add annotation to the page
        document
            .Pages[_model.Position.PageNumber]
            .Annotations
            .Add(polylineAnnotation);
            
        document.Save(Path.Combine(_workFolder, _outputFile));
    }
}
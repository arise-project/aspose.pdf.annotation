using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation;

public class LineAnnotator : IAnnotator
{
    private readonly LineModel _model;
    private readonly string _workFolder;
    private readonly string _inputFile;
    private readonly string _outputFile;

    public LineAnnotator(LineModel model, string workFolder, string inputFile, string outputFile)
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

// Create Line Annotation
        var lineAnnotation = new LineAnnotation(
            document.Pages[_model.Position.PageNumber], 
            new Rectangle(
                _model.Position.Llx, 
                _model.Position.Lly, 
                _model.Position.Urx,
                _model.Position.Ury,
                _model.Position.NormalizeCoordinates),
            new Point(556, 99), 
            new Point(556, 443))
        {
            Title = _model.Title.Title,
            Subject = _model.Title.Subject,
            Color = _model.Title.Color,
            Opacity = _model.Title.Opacity,
            Width = 3,
            StartingStyle = LineEnding.OpenArrow,
            EndingStyle = LineEnding.OpenArrow,
            Popup = new PopupAnnotation(
                document.Pages[_model.Position.PageNumber],
                new Rectangle(842, 124, 1021, 266))
        };

        // Add annotation to the page
        document
            .Pages[_model.Position.PageNumber]
            .Annotations
            .Add(lineAnnotation);
        
        document.Save(Path.Combine(_workFolder, _outputFile));
    }
}
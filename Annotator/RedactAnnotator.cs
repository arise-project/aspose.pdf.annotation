using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation;

public class RedactAnnotator : IAnnotator
{
    private readonly RedactModel _model;
    private readonly string _workFolder;
    private readonly string _inputFile;
    private readonly string _outputFile;

    public RedactAnnotator(RedactModel model, string workFolder, string inputFile, string outputFile)
    {
        _model = model;
        _workFolder = workFolder;
        _inputFile = inputFile;
        _outputFile = outputFile;
    }

    public void Add()
    {
        // Open document
        Document document = new Document(Path.Combine(_workFolder, _inputFile));

        // Create RedactionAnnotation instance for specific page region
        RedactionAnnotation annotation = new RedactionAnnotation(
            document.Pages[_model.Position.PageNumber], 
            new Rectangle(
                _model.Position.Llx, 
                _model.Position.Lly, 
                _model.Position.Urx,
                _model.Position.Ury,
                _model.Position.NormalizeCoordinates));
        
        annotation.FillColor = Aspose.Pdf.Color.Green;
        annotation.BorderColor = Aspose.Pdf.Color.Yellow;
        annotation.Color = Aspose.Pdf.Color.Blue;
        // Text to be printed on redact annotation
        annotation.OverlayText = "REDACTED";
        annotation.TextAlignment = Aspose.Pdf.HorizontalAlignment.Center;
        // Repat Overlay text over redact Annotation
        annotation.Repeat = true;
        
        // Add annotation to annotations collection of first page
        document
            .Pages[_model.Position.PageNumber]
            .Annotations
            .Add(annotation);
        
        // Flattens annotation and redacts page contents (i.e. removes text and image
        // Under redacted annotation)
        annotation.Redact();
        
        document.Save(Path.Combine(_workFolder, _outputFile));
    }
}
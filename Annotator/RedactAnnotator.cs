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
        Document doc = new Document(Path.Combine(_workFolder, _inputFile));

        // Create RedactionAnnotation instance for specific page region
        RedactionAnnotation annot = new RedactionAnnotation(doc.Pages[1], new Aspose.Pdf.Rectangle(200, 500, 300, 600));
        annot.FillColor = Aspose.Pdf.Color.Green;
        annot.BorderColor = Aspose.Pdf.Color.Yellow;
        annot.Color = Aspose.Pdf.Color.Blue;
        // Text to be printed on redact annotation
        annot.OverlayText = "REDACTED";
        annot.TextAlignment = Aspose.Pdf.HorizontalAlignment.Center;
        // Repat Overlay text over redact Annotation
        annot.Repeat = true;
        // Add annotation to annotations collection of first page
        doc.Pages[1].Annotations.Add(annot);
        // Flattens annotation and redacts page contents (i.e. removes text and image
        // Under redacted annotation)
        annot.Redact();
        doc.Save(Path.Combine(_workFolder, _outputFile));
    }
}
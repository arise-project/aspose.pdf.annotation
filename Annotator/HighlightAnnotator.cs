using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation;

public class HighlightAnnotator : IAnnotator
{
    private readonly HighlightModel _model;
    private readonly string _workFolder;
    private readonly string _inputFile;
    private readonly string _outputFile;

    public HighlightAnnotator(HighlightModel model, string workFolder, string inputFile, string outputFile)
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
        
        var tfa = new Aspose.Pdf.Text.TextFragmentAbsorber("PDF");
        tfa.Visit(document.Pages[1]);

        //Create annotations
        HighlightAnnotation highlightAnnotation = new HighlightAnnotation(
            document.Pages[_model.Page.PageNumber],
            tfa.TextFragments[1].Rectangle)
        {
            Title = _model.Title.Title,
            Subject = _model.Title.Subject,
            Color = _model.Title.Color
        };
        
        // Add annotation to the page
        document
            .Pages[_model.Page.PageNumber]
            .Annotations
            .Add(highlightAnnotation);
        
        document.Save(Path.Combine(_workFolder, _outputFile));
    }
}
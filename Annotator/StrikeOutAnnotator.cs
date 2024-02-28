using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation;

public class StrikeOutAnnotator : IAnnotator
{
    private readonly StrikeOutModel _model;
    private readonly string _workFolder;
    private readonly string _inputFile;
    private readonly string _outputFile;

    public StrikeOutAnnotator(StrikeOutModel model, string workFolder, string inputFile, string outputFile)
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
        
        var textFragmentAbsorber = new Aspose.Pdf.Text.TextFragmentAbsorber(_model.Text);
        textFragmentAbsorber.Visit(document.Pages[_model.Page.PageNumber]);

        StrikeOutAnnotation strikeOutAnnotation = new StrikeOutAnnotation(
            document.Pages[_model.Page.PageNumber],
            textFragmentAbsorber.TextFragments[1].Rectangle)
        {
            Title = _model.Title.Title,
            Subject = _model.Title.Subject,
            Color = _model.Title.Color,
            Opacity = _model.Title.Opacity
        };
        
        // Add annotation to the page
        document
            .Pages[_model.Page.PageNumber]
            .Annotations
            .Add(strikeOutAnnotation);
        
        document.Save(Path.Combine(_workFolder, _outputFile));
    }
}
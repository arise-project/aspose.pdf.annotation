using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation;

public class UnderlineAnnotator : IAnnotator
{
    private readonly UnderlineModel _model;
    private readonly string _workFolder;
    private readonly string _inputFile;
    private readonly string _outputFile;

    public UnderlineAnnotator(UnderlineModel model, string workFolder, string inputFile, string outputFile)
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
        tfa.Visit(document.Pages[_model.Page.PageNumber]);

        //Create annotations
        UnderlineAnnotation underlineAnnotation = new UnderlineAnnotation(
            document.Pages[_model.Page.PageNumber],
            tfa.TextFragments[4].Rectangle)
        {
            Title = "Aspose User",
            Color = Color.Violet
        };
        // Add annotation to the page
        document.Pages[1].Annotations.Add(underlineAnnotation);
        document.Save(Path.Combine(_workFolder, _outputFile));
    }
}
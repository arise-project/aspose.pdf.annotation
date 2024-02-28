using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation;

public class SquigglyAnnotator : IAnnotator
{
    private readonly SquigglyModel _model;
    private readonly string _workFolder;
    private readonly string _inputFile;
    private readonly string _outputFile;

    public SquigglyAnnotator(SquigglyModel model, string workFolder, string inputFile, string outputFile)
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
        
        SquigglyAnnotation squigglyAnnotation = new SquigglyAnnotation(
            document.Pages[_model.Page.PageNumber],
            tfa.TextFragments[3].Rectangle)
        {
            Title = "Aspose User",
            Color = Color.Red
        };
        
        // Add annotation to the page
        document.Pages[1].Annotations.Add(squigglyAnnotation);
        document.Save(Path.Combine(_workFolder, _outputFile));
    }
}
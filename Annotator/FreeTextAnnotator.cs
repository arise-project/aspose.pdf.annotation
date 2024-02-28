using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Facades;
using Aspose.Pdf.Text;

namespace aspose.pdf.annotation;

public class FreeTextAnnotator : IAnnotator
{
    private readonly FreeTextModel _model;
    private readonly string _workFolder;
    private readonly string _inputFile;
    private readonly string _outputFile;

    public FreeTextAnnotator(FreeTextModel model, string workFolder, string inputFile, string outputFile)
    {
        _model = model;
        _workFolder = workFolder;
        _inputFile = inputFile;
        _outputFile = outputFile;
    }

    public void Add()
    {
        var document = new Document(Path.Combine(_workFolder, _inputFile));
        
        var pdfContentEditor = new PdfContentEditor(document);
        
        var textFragmentAbsorber = new TextFragmentAbsorber();
        textFragmentAbsorber.Visit(document.Pages[_model.Page.PageNumber]);
        
        if (textFragmentAbsorber.TextFragments.Count <= 0) 
            return;
        
        var rect = new System.Drawing.Rectangle
        {
            X = (int)textFragmentAbsorber.TextFragments[1].Rectangle.LLX,
            Y = (int)textFragmentAbsorber.TextFragments[1].Rectangle.URY + 5,
            Height = 18,
            Width = 100
        };

        pdfContentEditor.CreateFreeText(
            rect, 
            _model.Text,
            _model.Page.PageNumber); // last param is a page number
        
        pdfContentEditor.Save(Path.Combine(_workFolder, _outputFile));
    }
}
using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Facades;
using Aspose.Pdf.Text;

namespace aspose.pdf.annotation;

public class FreeTextAnnotator : IAnnotator
{
    private readonly FreeTextModel _model;
    private readonly string _workFolder;

    public FreeTextAnnotator(FreeTextModel model, string workFolder)
    {
        _model = model;
        _workFolder = workFolder;
    }

    public void Add()
    {
        var _document = new Document(_workFolder+ @"pdf-sample.pdf");
        var pdfContentEditor = new PdfContentEditor(_document);
        var tfs = new TextFragmentAbsorber();
        tfs.Visit(_document.Pages[1]);
        if (tfs.TextFragments.Count <= 0) return;
        var rect = new System.Drawing.Rectangle
        {
            X = (int)tfs.TextFragments[1].Rectangle.LLX,
            Y = (int)tfs.TextFragments[1].Rectangle.URY + 5,
            Height = 18,
            Width = 100
        };

        pdfContentEditor.CreateFreeText(rect, "Free Text Demo", 1); // last param is a page number
        pdfContentEditor.Save(_workFolder + @"pdf-sample-0.pdf");
    }
}
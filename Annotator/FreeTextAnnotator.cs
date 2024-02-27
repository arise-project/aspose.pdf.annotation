using Aspose.Pdf;
using Aspose.Pdf.Facades;
using Aspose.Pdf.Text;

namespace aspose.pdf.annotation;

public class FreeTextAnnotator : IAnnotator
{
    public void Add()
    {
        var _document = new Document(@"C:\tmp\pdf-sample.pdf");
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
        pdfContentEditor.Save(@"C:\tmp\pdf-sample-0.pdf");
    }
}
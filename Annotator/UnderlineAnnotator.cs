using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation;

public class UnderlineAnnotator : IAnnotator
{
    private readonly UnderlineModel _model;
    private readonly string _workFolder;

    public UnderlineAnnotator(UnderlineModel model, string workFolder)
    {
        _model = model;
        _workFolder = workFolder;
    }
    
    public void Add()
    {
        // Load the PDF file
        Document document = new Document(System.IO.Path.Combine(_workFolder, "sample.pdf"));
        var tfa = new Aspose.Pdf.Text.TextFragmentAbsorber("PDF");
        tfa.Visit(document.Pages[1]);

        //Create annotations
        UnderlineAnnotation underlineAnnotation = new UnderlineAnnotation(document.Pages[1],
            tfa.TextFragments[4].Rectangle)
        {
            Title = "Aspose User",
            Color = Color.Violet
        };
        // Add annotation to the page
        document.Pages[1].Annotations.Add(underlineAnnotation);
        document.Save(System.IO.Path.Combine(_workFolder, "sample_mod.pdf"));
    }
}
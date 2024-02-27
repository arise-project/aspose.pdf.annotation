using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation;

public class StrikeOutAnnotator : IAnnotator
{
    private readonly StrikeOutModel _model;

    public StrikeOutAnnotator(StrikeOutModel model)
    {
        _model = model;
    }
    
    public void Add()
    {
        // Load the PDF file
        Document document = new Document(System.IO.Path.Combine("./examples", "sample.pdf"));
        var tfa = new Aspose.Pdf.Text.TextFragmentAbsorber("PDF");
        tfa.Visit(document.Pages[1]);

        StrikeOutAnnotation strikeOutAnnotation = new StrikeOutAnnotation(
            document.Pages[1],
            tfa.TextFragments[2].Rectangle)
        {
            Title = "Aspose User",
            Color = Color.Blue
        };
        
        // Add annotation to the page
        document.Pages[1].Annotations.Add(strikeOutAnnotation);
        document.Save(System.IO.Path.Combine("./examples", "sample_mod.pdf"));
    }
}
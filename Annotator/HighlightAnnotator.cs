using Aspose.Pdf;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation;

public class HighlightAnnotator : IAnnotator
{
    public void Add()
    {
        // Load the PDF file
        Document document = new Document(System.IO.Path.Combine("./examples", "sample.pdf"));
        var tfa = new Aspose.Pdf.Text.TextFragmentAbsorber("PDF");
        tfa.Visit(document.Pages[1]);

        //Create annotations
        HighlightAnnotation highlightAnnotation = new HighlightAnnotation(document.Pages[1],
            tfa.TextFragments[1].Rectangle)
        {
            Title = "Aspose User",
            Color = Color.LightGreen
        };
        
        // Add annotation to the page
        document.Pages[1].Annotations.Add(highlightAnnotation);
        document.Save(System.IO.Path.Combine("./examples", "sample_mod.pdf"));
    }
}
using Aspose.Pdf;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation;

public class SquigglyAnnotator : IAnnotator
{
    public void Add()
    {
        // Load the PDF file
        Document document = new Document(System.IO.Path.Combine("./examples", "sample.pdf"));
        var tfa = new Aspose.Pdf.Text.TextFragmentAbsorber("PDF");
        tfa.Visit(document.Pages[1]);
        
        SquigglyAnnotation squigglyAnnotation = new SquigglyAnnotation(document.Pages[1],
            tfa.TextFragments[3].Rectangle)
        {
            Title = "Aspose User",
            Color = Color.Red
        };
        
        // Add annotation to the page
        document.Pages[1].Annotations.Add(squigglyAnnotation);
        document.Save(System.IO.Path.Combine("./examples", "sample_mod.pdf"));
    }
}
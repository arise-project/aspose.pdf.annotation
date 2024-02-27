using Aspose.Pdf;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation;

public class UnderlineAnnotator : IAnnotator
{
    public void Add()
    {
        // Load the PDF file
        Document document = new Document(System.IO.Path.Combine("./examples", "sample.pdf"));
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
        document.Save(System.IO.Path.Combine("./examples", "sample_mod.pdf"));
    }
}
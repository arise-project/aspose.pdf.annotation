using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Annotations;
using Aspose.Pdf.Text;

namespace aspose.pdf.annotation;

public class LinkAnnotator : IAnnotator
{
    private readonly LinkModel _model;

    public LinkAnnotator(LinkModel model)
    {
        _model = model;
    }

    public void Add()
    {
        // Load the PDF file
        Document document = new Document(System.IO.Path.Combine("./examples", "SimpleResume.pdf"));
        // Create TextFragmentAbsorber object to find a phone number
        TextFragmentAbsorber textFragmentAbsorber = new TextFragmentAbsorber("678-555-0103");

        // Accept the absorber for the 1st page only
        document.Pages[1].Accept(textFragmentAbsorber);

        var phoneNumberFragment = textFragmentAbsorber.TextFragments[1];

        // Create Link Annotation and set the action to call a phone number
        var linkAnnotation = new LinkAnnotation(document.Pages[1], phoneNumberFragment.Rectangle)
        {
            Action = new GoToURIAction("callto:678-555-0103")
        };

        // Add annotation to page
        document.Pages[1].Annotations.Add(linkAnnotation);
        document.Save(System.IO.Path.Combine("./examples", "SimpleResume_mod.pdf"));
    }
}
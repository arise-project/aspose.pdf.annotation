using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Annotations;
using Aspose.Pdf.Text;

namespace aspose.pdf.annotation;

public class LinkAnnotator : IAnnotator
{
    private readonly LinkModel _model;
    private readonly string _workFolder;
    private readonly string _inputFile;
    private readonly string _outputFile;

    public LinkAnnotator(LinkModel model, string workFolder, string inputFile, string outputFile)
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
        // Create TextFragmentAbsorber object to find a phone number
        TextFragmentAbsorber textFragmentAbsorber = new TextFragmentAbsorber("678-555-0103");

        // Accept the absorber for the 1st page only
        document.Pages[_model.Page.PageNumber].Accept(textFragmentAbsorber);

        var phoneNumberFragment = textFragmentAbsorber.TextFragments[1];

        // Create Link Annotation and set the action to call a phone number
        var linkAnnotation = new LinkAnnotation(document.Pages[1], phoneNumberFragment.Rectangle)
        {
            Action = new GoToURIAction("callto:678-555-0103")
        };

        // Add annotation to page
        document.Pages[1].Annotations.Add(linkAnnotation);
        document.Save(Path.Combine(_workFolder, _outputFile));
    }
}